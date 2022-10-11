﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/5/2022 1:06:25 PM
namespace Checkmarx.API.SAST.OData
{
    /// <summary>
    /// There are no comments for QueryLanguageSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("QueryLanguageSingle")]
    public partial class QueryLanguageSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<QueryLanguage>
    {
        /// <summary>
        /// Initialize a new QueryLanguageSingle object.
        /// </summary>
        public QueryLanguageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new QueryLanguageSingle object.
        /// </summary>
        public QueryLanguageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new QueryLanguageSingle object.
        /// </summary>
        public QueryLanguageSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<QueryLanguage> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for QueryLanguage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LanguageId
    /// VersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LanguageId", "VersionId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("QueryLanguage")]
    public partial class QueryLanguage : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new QueryLanguage object.
        /// </summary>
        /// <param name="versionId">Initial value of VersionId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="versionDate">Initial value of VersionDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static QueryLanguage CreateQueryLanguage(int versionId, int languageId, global::System.DateTimeOffset versionDate)
        {
            QueryLanguage queryLanguage = new QueryLanguage();
            queryLanguage.VersionId = versionId;
            queryLanguage.LanguageId = languageId;
            queryLanguage.VersionDate = versionDate;
            return queryLanguage;
        }
        /// <summary>
        /// There are no comments for Property VersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VersionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VersionId is required.")]
        public virtual int VersionId
        {
            get
            {
                return this._VersionId;
            }
            set
            {
                this.OnVersionIdChanging(value);
                this._VersionId = value;
                this.OnVersionIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _VersionId;
        partial void OnVersionIdChanging(int value);
        partial void OnVersionIdChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LanguageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LanguageId is required.")]
        public virtual int LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LanguageId;
        partial void OnLanguageIdChanging(int value);
        partial void OnLanguageIdChanged();
        /// <summary>
        /// There are no comments for Property LanguageName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LanguageName")]
        public virtual string LanguageName
        {
            get
            {
                return this._LanguageName;
            }
            set
            {
                this.OnLanguageNameChanging(value);
                this._LanguageName = value;
                this.OnLanguageNameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageName;
        partial void OnLanguageNameChanging(string value);
        partial void OnLanguageNameChanged();
        /// <summary>
        /// There are no comments for Property VersionHash in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VersionHash")]
        public virtual string VersionHash
        {
            get
            {
                return this._VersionHash;
            }
            set
            {
                this.OnVersionHashChanging(value);
                this._VersionHash = value;
                this.OnVersionHashChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VersionHash;
        partial void OnVersionHashChanging(string value);
        partial void OnVersionHashChanged();
        /// <summary>
        /// There are no comments for Property VersionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VersionDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VersionDate is required.")]
        public virtual global::System.DateTimeOffset VersionDate
        {
            get
            {
                return this._VersionDate;
            }
            set
            {
                this.OnVersionDateChanging(value);
                this._VersionDate = value;
                this.OnVersionDateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _VersionDate;
        partial void OnVersionDateChanging(global::System.DateTimeOffset value);
        partial void OnVersionDateChanged();
    }
}
