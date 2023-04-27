using System.Collections.Generic;
using TypeGen.Core.TypeAnnotations;

namespace TypeGen.Core.SpecGeneration
{
    /// <summary>
    /// Base class for class, interface and struct spec builders
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TDerived"></typeparam>
    public abstract class ClassOrInterfaceOrStructSpecBuilder<T, TDerived> : TypeSpecBuilder<T, TDerived> where TDerived : ClassOrInterfaceOrStructSpecBuilder<T, TDerived>
    {
        internal ClassOrInterfaceOrStructSpecBuilder(TypeSpec spec) : base(spec) { }

        /// <summary>
        /// Indicates whether to use default export for the generated TypeScript type (equivalent of TsDefaultExportAttribute)
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public TDerived DefaultExport(bool enabled = true)
        {
            AddTypeAttribute(new TsDefaultExportAttribute(enabled));
            return this as TDerived;
        }

        /// <summary>
        /// Specifies the default type output path for the selected member (equivalent of TsDefaultTypeOutputAttribute)
        /// </summary>
        /// <param name="outputDir"></param>
        /// <returns></returns>
        public TDerived DefaultTypeOutput(string outputDir)
        {
            AddActiveMemberAttribute(new TsDefaultTypeOutputAttribute(outputDir));
            return this as TDerived;
        }

        /// <summary>
        /// Specifies default value for the selected member (equivalent of TsDefaultValueAttribute)
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public TDerived DefaultValue(string defaultValue)
        {
            AddActiveMemberAttribute(new TsDefaultValueAttribute(defaultValue));
            return this as TDerived;
        }

        /// <summary>
        /// Marks selected member as ignored (equivalent of TsIgnoreAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived Ignore()
        {
            AddActiveMemberAttribute(new TsIgnoreAttribute());
            return this as TDerived;
        }

        /// <summary>
        /// Indicates whether to ignore base class declaration for type (equivalent of TsIgnoreBaseAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived IgnoreBase()
        {
            AddTypeAttribute(new TsIgnoreBaseAttribute());
            return this as TDerived;
        }

        /// <summary>
        /// Specifies name for the selected member (equivalent of TsMemberNameAttribute)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TDerived MemberName(string name)
        {
            AddActiveMemberAttribute(new TsMemberNameAttribute(name));
            return this as TDerived;
        }

        /// <summary>
        /// Marks selected member as not null (equivalent of TsNotNullAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived NotNull()
        {
            AddActiveMemberAttribute(new TsNotNullAttribute());
            return this as TDerived;
        }

        /// <summary>
        /// Marks selected member as not readonly (equivalent of TsNotReadonlyAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived NotReadonly()
        {
            AddActiveMemberAttribute(new TsNotReadonlyAttribute());
            return this as TDerived;
        }

        /// <summary>
        /// Marks selected member as not undefined (equivalent of TsNotUndefinedAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived NotUndefined()
        {
            AddActiveMemberAttribute(new TsNotUndefinedAttribute());
            return this as TDerived;
        }

        /// <summary>
        /// Marks selected member as null (equivalent of TsNullAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived Null()
        {
            AddActiveMemberAttribute(new TsNullAttribute());
            return this as TDerived;
        }

        /// <summary>
        /// Marks selected member as readonly (equivalent of TsReadonlyAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived Readonly()
        {
            AddActiveMemberAttribute(new TsReadonlyAttribute());
            return this as TDerived;
        }

        /// <summary>
        /// Specifies custom type for the selected member (equivalent of TsTypeAttribute)
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="importPath"></param>
        /// <param name="originalTypeName"></param>
        /// <param name="isDefaultExport"></param>
        /// <returns></returns>
        public TDerived Type(string typeName, string importPath = null, string originalTypeName = null, bool isDefaultExport = false)
        {
            AddActiveMemberAttribute(new TsTypeAttribute(typeName, importPath, originalTypeName, isDefaultExport));
            return this as TDerived;
        }

        /// <summary>
        /// Specifies custom type for the selected member (equivalent of TsTypeAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived Type(TsType tsType)
        {
            AddActiveMemberAttribute(new TsTypeAttribute(tsType));
            return this as TDerived;
        }

        /// <summary>
        /// Specifies TypeScript type unions (excluding the main type) for a property or field (equivalent of TsTypeUnionsAttribute)
        /// </summary>
        /// <param name="typeUnions"></param>
        /// <returns></returns>
        public TDerived TypeUnions(IEnumerable<string> typeUnions)
        {
            AddActiveMemberAttribute(new TsTypeUnionsAttribute(typeUnions));
            return this as TDerived;
        }

        /// <summary>
        /// Specifies TypeScript type unions (excluding the main type) for a property or field (equivalent of TsTypeUnionsAttribute)
        /// </summary>
        /// <param name="typeUnions"></param>
        /// <returns></returns>
        public TDerived TypeUnions(params string[] typeUnions)
        {
            AddActiveMemberAttribute(new TsTypeUnionsAttribute(typeUnions));
            return this as TDerived;
        }

        /// <summary>
        /// Marks selected member as undefined (equivalent of TsUndefinedAttribute)
        /// </summary>
        /// <returns></returns>
        public TDerived Undefined()
        {
            AddActiveMemberAttribute(new TsUndefinedAttribute());
            return this as TDerived;
        }
    }
}