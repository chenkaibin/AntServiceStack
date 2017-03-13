﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntServiceStack.Common.Types
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using AntServiceStack.ProtoBuf;
    using AntServiceStack.ServiceHost;
    using AntServiceStack.Baiji.Specific;
    using System.Linq;
    
    
    /// <summary>
    /// This is serivce, validation or framework-level error.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace= "http://soa.ant.com/common/types/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace= "http://soa.ant.com/common/types/v1", IsNullable=true)]
    [DataContract(Namespace= "http://soa.ant.com/common/types/v1")]
    [ProtoContract()]
    public partial class ErrorDataType : ISpecificRecord
    {
        
        private string messageField;
        
        private string errorCodeField;
        
        private string stackTraceField;
        
        private SeverityCodeType severityCodeField;
        
        private List<ErrorFieldType> errorFieldsField;
        
        private ErrorClassificationCodeType errorClassificationField;
        
        public static readonly AntServiceStack.Baiji.Schema.Schema SCHEMA = AntServiceStack.Baiji.Schema.Schema.Parse(((("{\"type\":\"record\",\"name\":\"ErrorDataType\",\"namespace\":\"" + typeof(ErrorDataType).Namespace) 
                        + (("\",\"doc\":null,\"fields\":[{\"name\":\"Message\",\"type\":[\"string\",\"null\"]},{\"name\":\"Error" +
                            "Code\",\"type\":[\"string\",\"null\"]},{\"name\":\"StackTrace\",\"type\":[\"string\",\"null\"]},{" +
                            "\"name\":\"SeverityCode\",\"type\":{\"type\":\"enum\",\"name\":\"SeverityCodeType\",\"namespace" +
                            "\":\"" + typeof(SeverityCodeType).Namespace) 
                        + (("\",\"doc\":null,\"symbols\":[\"Error\",\"Warning\"]}},{\"name\":\"ErrorFields\",\"type\":[{\"type" +
                            "\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"ErrorFieldType\",\"namespace\":\"" + typeof(ErrorFieldType).Namespace) 
                        + (@""",""doc"":null,""fields"":[{""name"":""FieldName"",""type"":[""string"",""null""]},{""name"":""ErrorCode"",""type"":[""string"",""null""]},{""name"":""Message"",""type"":[""string"",""null""]}]}},""null""]},{""name"":""ErrorClassification"",""type"":{""type"":""enum"",""name"":""ErrorClassificationCodeType"",""namespace"":""" + typeof(ErrorClassificationCodeType).Namespace)))) 
                        + "\",\"doc\":null,\"symbols\":[\"ServiceError\",\"ValidationError\",\"FrameworkError\",\"SLAErr" +
                            "or\"]}}]}"));
        
        /// <summary>
        /// A brief description of the condition that raised the error.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <summary>
        /// A unique code that identifies the particular error condition that occurred.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        [DataMember()]
        [ProtoMember(2)]
        public string ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <summary>
        /// StackTrace of exception causing this error, only used in debug mode.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string StackTrace
        {
            get
            {
                return this.stackTraceField;
            }
            set
            {
                this.stackTraceField = value;
            }
        }
        
        /// <summary>
        /// Indicates whether the reported problem is fatal (an error) or is less-
        /// severe (a warning). Review the error message details for information on
        /// the cause.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public SeverityCodeType SeverityCode
        {
            get
            {
                return this.severityCodeField;
            }
            set
            {
                this.severityCodeField = value;
            }
        }
        
        /// <summary>
        /// Some warning and error messages return one or more variables that
        /// contain contextual information about the error. This is often the
        /// field or value that triggered the error.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ErrorFields")]
        [DataMember()]
        [ProtoMember(5)]
        public List<ErrorFieldType> ErrorFields
        {
            get
            {
                if ((this.errorFieldsField == null))
                {
                    this.errorFieldsField = new List<ErrorFieldType>();
                }
                return this.errorFieldsField;
            }
            set
            {
                this.errorFieldsField = value;
            }
        }
        
        /// <summary>
        /// API errors are divided between three classes: service errors, validation errors and framework errors.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public ErrorClassificationCodeType ErrorClassification
        {
            get
            {
                return this.errorClassificationField;
            }
            set
            {
                this.errorClassificationField = value;
            }
        }
        
        public virtual AntServiceStack.Baiji.Schema.Schema GetSchema()
        {
            return SCHEMA;
        }
        
        public virtual object Get(int fieldPos)
        {
            switch(fieldPos)
            {
                case 0: return this.Message;
                case 1: return this.ErrorCode;
                case 2: return this.StackTrace;
                case 3: return this.SeverityCode;
                case 4: return this.ErrorFields;
                case 5: return this.ErrorClassification;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Get()");
            }
        }
        
        public virtual void Put(int fieldPos, object fieldValue)
        {
            switch(fieldPos)
            {
                case 0: this.Message = (System.String)fieldValue; break;
                case 1: this.ErrorCode = (System.String)fieldValue; break;
                case 2: this.StackTrace = (System.String)fieldValue; break;
                case 3: this.SeverityCode = (SeverityCodeType)fieldValue; break;
                case 4: this.ErrorFields = (List<ErrorFieldType>)fieldValue; break;
                case 5: this.ErrorClassification = (ErrorClassificationCodeType)fieldValue; break;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Put()");
            }
        }
        
        public virtual object Get(string fieldName)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return null;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return null;
            }
            return Get(field.Pos);
        }
        
        public virtual void Put(string fieldName, object fieldValue)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return ;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return ;
            }
            Put(field.Pos, fieldValue);
        }
    }
}