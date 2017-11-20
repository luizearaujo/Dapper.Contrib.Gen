using DapperContrib.Gen.Entity;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace DapperContrib.Gen.CodeDOM
{
    public class CodeGen
    {
        public void Gen(Table table)
        {

            GenEntity(table);
            GenRepository(table);

        }

        private void GenEntity(Table table)
        {
            var className = this.Format(table.Name);

            var targetUnit = new CodeCompileUnit();
            var nameSpace = new CodeNamespace("Repository.Entity");

            nameSpace.Imports.Add(new CodeNamespaceImport("System"));
            nameSpace.Imports.Add(new CodeNamespaceImport("Dapper.Contrib.Extensions"));

            var targetClass = new CodeTypeDeclaration(className);
            targetClass.IsClass = true;
            targetClass.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;

            var classAttribute = new CodeAttributeDeclaration("Dapper.Contrib.Extensions.Table",
                new CodeAttributeArgument(new CodePrimitiveExpression($"[{table.Schema}].[{table.Name}]")));
            targetClass.CustomAttributes.Add(classAttribute);

            nameSpace.Types.Add(targetClass);
            targetUnit.Namespaces.Add(nameSpace);


            foreach (var c in table.Columns)
            {
                var p = new CodeMemberProperty();
                p.Attributes = MemberAttributes.Public | MemberAttributes.Final;

                p.Name = Format(c.Name);
                p.HasGet = true;

                p.Type = ConvertDbType(c);

                if (c.PrimaryKey)
                {
                    var propertiAttribute = new CodeAttributeDeclaration("ExplicitKey");
                    p.CustomAttributes.Add(propertiAttribute);
                }


                targetClass.Members.Add(p);
            }

            var outputFileName = $"{className}.cs";
            var provider = CodeDomProvider.CreateProvider("CSharp");
            var options = new CodeGeneratorOptions();
            options.BracingStyle = "C";
            using (var sourceWriter = new StreamWriter($@"c:\temp\{outputFileName}"))
            {
                provider.GenerateCodeFromCompileUnit(targetUnit, sourceWriter, options);
            }
        }

        private void GenRepository(Table table)
        {
            var className = this.Format($"{table.Name}Repository");

            var targetUnit = new CodeCompileUnit();
            var nameSpace = new CodeNamespace("Repository");

            nameSpace.Imports.Add(new CodeNamespaceImport("System"));
            nameSpace.Imports.Add(new CodeNamespaceImport("Dapper.Contrib.Extensions"));

            var targetClass = new CodeTypeDeclaration(className);
            targetClass.IsClass = true;
            targetClass.TypeAttributes = TypeAttributes.Public;

            nameSpace.Types.Add(targetClass);
            targetUnit.Namespaces.Add(nameSpace);

            var getAllMethod = new CodeMemberMethod();
            getAllMethod.Attributes = MemberAttributes.Public;
            getAllMethod.Name = "Get";
            getAllMethod.ReturnType = new CodeTypeReference(typeof(IList<object>));
            targetClass.Members.Add(getAllMethod);


            var getMethod = new CodeMemberMethod();
            getMethod.Attributes = MemberAttributes.Public;
            getMethod.Name = "Get";
            getMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(object), "id"));
            getMethod.ReturnType = new CodeTypeReference(typeof(object));
            targetClass.Members.Add(getMethod);

            var newMethod = new CodeMemberMethod();
            newMethod.Attributes = MemberAttributes.Public;
            newMethod.Name = "New";
            newMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(object), "entity"));
            newMethod.ReturnType = new CodeTypeReference(typeof(bool));
            targetClass.Members.Add(newMethod);

            var updateMethod = new CodeMemberMethod();
            updateMethod.Attributes = MemberAttributes.Public;
            updateMethod.Name = "Update";
            updateMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(object), "entity"));
            updateMethod.ReturnType = new CodeTypeReference(typeof(bool));
            targetClass.Members.Add(updateMethod);

            var deleteMethod = new CodeMemberMethod();
            deleteMethod.Attributes = MemberAttributes.Public;
            deleteMethod.Name = "Delete";
            deleteMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(object), "id"));
            deleteMethod.ReturnType = new CodeTypeReference(typeof(bool));
            targetClass.Members.Add(deleteMethod);


            var outputFileName = $"{className}.cs";
            var provider = CodeDomProvider.CreateProvider("CSharp");
            var options = new CodeGeneratorOptions();
            options.BracingStyle = "C";
            using (var sourceWriter = new StreamWriter($@"c:\temp\{outputFileName}"))
            {
                provider.GenerateCodeFromCompileUnit(targetUnit, sourceWriter, options);
            }

        }

        private string Format(string word)
        {
            var temp = word.Replace("_", " ");

            temp = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(temp.ToLower());

            return temp.Replace(" ", "_");
        }

        private CodeTypeReference ConvertDbType(Column c)
        {

            if (c.DataType.Contains("VARCHAR"))
                return new CodeTypeReference(typeof(string));
            if (c.DataType.Contains("NUMERIC"))
            {
                if (c.Precision > 0)
                    return c.IsNullable
                        ? new CodeTypeReference(typeof(decimal?))
                        : new CodeTypeReference(typeof(decimal));
                else
                {
                    if (c.Size < 8)
                        return c.IsNullable
                        ? new CodeTypeReference(typeof(int?))
                        : new CodeTypeReference(typeof(int));
                    else
                        return c.IsNullable
                        ? new CodeTypeReference(typeof(long?))
                        : new CodeTypeReference(typeof(long));
                }
            }
            if (c.DataType.Contains("DATE") || c.DataType.Contains("DATETIME") || c.DataType.Contains("DATETIME2"))
                return c.IsNullable
                ? new CodeTypeReference(typeof(System.DateTime?))
                : new CodeTypeReference(typeof(System.DateTime));
            if (c.DataType.Contains("UNIQUEIDENTIFIER"))
                return c.IsNullable
                ? new CodeTypeReference(typeof(System.Guid?))
                : new CodeTypeReference(typeof(System.Guid));
            else
                return new CodeTypeReference(typeof(object));
        }
    }
}
