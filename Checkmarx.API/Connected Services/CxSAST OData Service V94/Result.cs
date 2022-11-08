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
    /// There are no comments for ResultSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ResultSingle")]
    public partial class ResultSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Result>
    {
        /// <summary>
        /// Initialize a new ResultSingle object.
        /// </summary>
        public ResultSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ResultSingle object.
        /// </summary>
        public ResultSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ResultSingle object.
        /// </summary>
        public ResultSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Result> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Query in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Query")]
        public virtual Checkmarx.API.SAST.OData.QuerySingle Query
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Query == null))
                {
                    this._Query = new Checkmarx.API.SAST.OData.QuerySingle(this.Context, GetPath("Query"));
                }
                return this._Query;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.QuerySingle _Query;
        /// <summary>
        /// There are no comments for Scan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Scan")]
        public virtual Checkmarx.API.SAST.OData.ScanSingle Scan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Scan == null))
                {
                    this._Scan = new Checkmarx.API.SAST.OData.ScanSingle(this.Context, GetPath("Scan"));
                }
                return this._Scan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.ScanSingle _Scan;
        /// <summary>
        /// There are no comments for AssignedToUser in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignedToUser")]
        public virtual Checkmarx.API.SAST.OData.UserSingle AssignedToUser
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssignedToUser == null))
                {
                    this._AssignedToUser = new Checkmarx.API.SAST.OData.UserSingle(this.Context, GetPath("AssignedToUser"));
                }
                return this._AssignedToUser;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.UserSingle _AssignedToUser;
        /// <summary>
        /// There are no comments for State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        public virtual Checkmarx.API.SAST.OData.ResultStateSingle State
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._State == null))
                {
                    this._State = new Checkmarx.API.SAST.OData.ResultStateSingle(this.Context, GetPath("State"));
                }
                return this._State;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.ResultStateSingle _State;
    }
    /// <summary>
    /// There are no comments for Result in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// ScanId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id", "ScanId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Result")]
    public partial class Result : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new Result object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="similarityId">Initial value of SimilarityId.</param>
        /// <param name="pathId">Initial value of PathId.</param>
        /// <param name="date">Initial value of Date.</param>
        /// <param name="severity">Initial value of Severity.</param>
        /// <param name="stateId">Initial value of StateId.</param>
        /// <param name="queryVersionId">Initial value of QueryVersionId.</param>
        /// <param name="detectionDate">Initial value of DetectionDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Result CreateResult(int ID, 
                    long similarityId, 
                    long pathId, 
                    global::System.DateTimeOffset date, 
                    Checkmarx.API.SAST.OData.Severity severity, 
                    int stateId, 
                    long queryVersionId, 
                    global::System.DateTimeOffset detectionDate)
        {
            Result result = new Result();
            result.Id = ID;
            result.SimilarityId = similarityId;
            result.PathId = pathId;
            result.Date = date;
            result.Severity = severity;
            result.StateId = stateId;
            result.QueryVersionId = queryVersionId;
            result.DetectionDate = detectionDate;
            return result;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ResultId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResultId")]
        public virtual string ResultId
        {
            get
            {
                return this._ResultId;
            }
            set
            {
                this.OnResultIdChanging(value);
                this._ResultId = value;
                this.OnResultIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResultId;
        partial void OnResultIdChanging(string value);
        partial void OnResultIdChanged();
        /// <summary>
        /// There are no comments for Property ScanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScanId")]
        public virtual global::System.Nullable<long> ScanId
        {
            get
            {
                return this._ScanId;
            }
            set
            {
                this.OnScanIdChanging(value);
                this._ScanId = value;
                this.OnScanIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<long> _ScanId;
        partial void OnScanIdChanging(global::System.Nullable<long> value);
        partial void OnScanIdChanged();
        /// <summary>
        /// There are no comments for Property SimilarityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SimilarityId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SimilarityId is required.")]
        public virtual long SimilarityId
        {
            get
            {
                return this._SimilarityId;
            }
            set
            {
                this.OnSimilarityIdChanging(value);
                this._SimilarityId = value;
                this.OnSimilarityIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SimilarityId;
        partial void OnSimilarityIdChanging(long value);
        partial void OnSimilarityIdChanged();
        /// <summary>
        /// There are no comments for Property RawPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RawPriority")]
        public virtual global::System.Nullable<float> RawPriority
        {
            get
            {
                return this._RawPriority;
            }
            set
            {
                this.OnRawPriorityChanging(value);
                this._RawPriority = value;
                this.OnRawPriorityChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<float> _RawPriority;
        partial void OnRawPriorityChanging(global::System.Nullable<float> value);
        partial void OnRawPriorityChanged();
        /// <summary>
        /// There are no comments for Property PathId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PathId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PathId is required.")]
        public virtual long PathId
        {
            get
            {
                return this._PathId;
            }
            set
            {
                this.OnPathIdChanging(value);
                this._PathId = value;
                this.OnPathIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PathId;
        partial void OnPathIdChanging(long value);
        partial void OnPathIdChanged();
        /// <summary>
        /// There are no comments for Property ConfidenceLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfidenceLevel")]
        public virtual global::System.Nullable<int> ConfidenceLevel
        {
            get
            {
                return this._ConfidenceLevel;
            }
            set
            {
                this.OnConfidenceLevelChanging(value);
                this._ConfidenceLevel = value;
                this.OnConfidenceLevelChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ConfidenceLevel;
        partial void OnConfidenceLevelChanging(global::System.Nullable<int> value);
        partial void OnConfidenceLevelChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Date is required.")]
        public virtual global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property Severity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Severity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Severity is required.")]
        public virtual Checkmarx.API.SAST.OData.Severity Severity
        {
            get
            {
                return this._Severity;
            }
            set
            {
                this.OnSeverityChanging(value);
                this._Severity = value;
                this.OnSeverityChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.Severity _Severity;
        partial void OnSeverityChanging(Checkmarx.API.SAST.OData.Severity value);
        partial void OnSeverityChanged();
        /// <summary>
        /// There are no comments for Property StateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StateId is required.")]
        public virtual int StateId
        {
            get
            {
                return this._StateId;
            }
            set
            {
                this.OnStateIdChanging(value);
                this._StateId = value;
                this.OnStateIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StateId;
        partial void OnStateIdChanging(int value);
        partial void OnStateIdChanged();
        /// <summary>
        /// There are no comments for Property AssignedToUserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignedToUserId")]
        public virtual global::System.Nullable<int> AssignedToUserId
        {
            get
            {
                return this._AssignedToUserId;
            }
            set
            {
                this.OnAssignedToUserIdChanging(value);
                this._AssignedToUserId = value;
                this.OnAssignedToUserIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AssignedToUserId;
        partial void OnAssignedToUserIdChanging(global::System.Nullable<int> value);
        partial void OnAssignedToUserIdChanged();
        /// <summary>
        /// There are no comments for Property AssignedTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignedTo")]
        public virtual string AssignedTo
        {
            get
            {
                return this._AssignedTo;
            }
            set
            {
                this.OnAssignedToChanging(value);
                this._AssignedTo = value;
                this.OnAssignedToChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssignedTo;
        partial void OnAssignedToChanging(string value);
        partial void OnAssignedToChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Comment")]
        public virtual string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        /// <summary>
        /// There are no comments for Property QueryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryId")]
        public virtual global::System.Nullable<long> QueryId
        {
            get
            {
                return this._QueryId;
            }
            set
            {
                this.OnQueryIdChanging(value);
                this._QueryId = value;
                this.OnQueryIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<long> _QueryId;
        partial void OnQueryIdChanging(global::System.Nullable<long> value);
        partial void OnQueryIdChanged();
        /// <summary>
        /// There are no comments for Property QueryVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryVersionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QueryVersionId is required.")]
        public virtual long QueryVersionId
        {
            get
            {
                return this._QueryVersionId;
            }
            set
            {
                this.OnQueryVersionIdChanging(value);
                this._QueryVersionId = value;
                this.OnQueryVersionIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _QueryVersionId;
        partial void OnQueryVersionIdChanging(long value);
        partial void OnQueryVersionIdChanged();
        /// <summary>
        /// There are no comments for Property DetectionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DetectionDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DetectionDate is required.")]
        public virtual global::System.DateTimeOffset DetectionDate
        {
            get
            {
                return this._DetectionDate;
            }
            set
            {
                this.OnDetectionDateChanging(value);
                this._DetectionDate = value;
                this.OnDetectionDateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DetectionDate;
        partial void OnDetectionDateChanging(global::System.DateTimeOffset value);
        partial void OnDetectionDateChanged();
        /// <summary>
        /// There are no comments for Property Query in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Query")]
        public virtual Checkmarx.API.SAST.OData.Query Query
        {
            get
            {
                return this._Query;
            }
            set
            {
                this.OnQueryChanging(value);
                this._Query = value;
                this.OnQueryChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.Query _Query;
        partial void OnQueryChanging(Checkmarx.API.SAST.OData.Query value);
        partial void OnQueryChanged();
        /// <summary>
        /// There are no comments for Property Scan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Scan")]
        public virtual Checkmarx.API.SAST.OData.Scan Scan
        {
            get
            {
                return this._Scan;
            }
            set
            {
                this.OnScanChanging(value);
                this._Scan = value;
                this.OnScanChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.Scan _Scan;
        partial void OnScanChanging(Checkmarx.API.SAST.OData.Scan value);
        partial void OnScanChanged();
        /// <summary>
        /// There are no comments for Property AssignedToUser in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignedToUser")]
        public virtual Checkmarx.API.SAST.OData.User AssignedToUser
        {
            get
            {
                return this._AssignedToUser;
            }
            set
            {
                this.OnAssignedToUserChanging(value);
                this._AssignedToUser = value;
                this.OnAssignedToUserChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.User _AssignedToUser;
        partial void OnAssignedToUserChanging(Checkmarx.API.SAST.OData.User value);
        partial void OnAssignedToUserChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        public virtual Checkmarx.API.SAST.OData.ResultState State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private Checkmarx.API.SAST.OData.ResultState _State;
        partial void OnStateChanging(Checkmarx.API.SAST.OData.ResultState value);
        partial void OnStateChanged();
    }
}