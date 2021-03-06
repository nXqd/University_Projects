﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Host.ServiceReference1 {
    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "StudentDTO", Namespace = "http://schemas.datacontract.org/2004/07/QLHS_WCF")]
    [Serializable]
    public class StudentDTO : object, IExtensibleDataObject, INotifyPropertyChanged {
        [OptionalField] private float AvgField;

        [OptionalField] private DateTime BirthdayField;

        [OptionalField] private string CodeField;

        [OptionalField] private string FullnameField;

        [OptionalField] private int IdField;

        [OptionalField] private bool StatusField;
        [NonSerialized] private ExtensionDataObject extensionDataField;

        [DataMember]
        public float Avg {
            get { return AvgField; }
            set {
                if ((AvgField.Equals(value) != true)) {
                    AvgField = value;
                    RaisePropertyChanged("Avg");
                }
            }
        }

        [DataMember]
        public DateTime Birthday {
            get { return BirthdayField; }
            set {
                if ((BirthdayField.Equals(value) != true)) {
                    BirthdayField = value;
                    RaisePropertyChanged("Birthday");
                }
            }
        }

        [DataMember]
        public string Code {
            get { return CodeField; }
            set {
                if ((ReferenceEquals(CodeField, value) != true)) {
                    CodeField = value;
                    RaisePropertyChanged("Code");
                }
            }
        }

        [DataMember]
        public string Fullname {
            get { return FullnameField; }
            set {
                if ((ReferenceEquals(FullnameField, value) != true)) {
                    FullnameField = value;
                    RaisePropertyChanged("Fullname");
                }
            }
        }

        [DataMember]
        public int Id {
            get { return IdField; }
            set {
                if ((IdField.Equals(value) != true)) {
                    IdField = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        [DataMember]
        public bool Status {
            get { return StatusField; }
            set {
                if ((StatusField.Equals(value) != true)) {
                    StatusField = value;
                    RaisePropertyChanged("Status");
                }
            }
        }

        #region IExtensibleDataObject Members

        [Browsable(false)]
        public ExtensionDataObject ExtensionData {
            get { return extensionDataField; }
            set { extensionDataField = value; }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "ServiceReference1.IService1")]
    public interface IService1 {
        [OperationContract(Action = "http://tempuri.org/IService1/GetData",
            ReplyAction = "http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);

        [OperationContract(Action = "http://tempuri.org/IService1/GetAllStudents",
            ReplyAction = "http://tempuri.org/IService1/GetAllStudentsResponse")]
        StudentDTO[] GetAllStudents();

        [OperationContract(Action = "http://tempuri.org/IService1/DeleteStudent",
            ReplyAction = "http://tempuri.org/IService1/DeleteStudentResponse")]
        bool DeleteStudent(StudentDTO student);

        [OperationContract(Action = "http://tempuri.org/IService1/UpdateStudent",
            ReplyAction = "http://tempuri.org/IService1/UpdateStudentResponse")]
        bool UpdateStudent(StudentDTO student);

        [OperationContract(Action = "http://tempuri.org/IService1/CreateStudent",
            ReplyAction = "http://tempuri.org/IService1/CreateStudentResponse")]
        void CreateStudent(StudentDTO student);
    }

    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : IService1, IClientChannel {
    }

    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class Service1Client : ClientBase<IService1>, IService1 {
        public Service1Client() {
        }

        public Service1Client(string endpointConfigurationName) :
            base(endpointConfigurationName) {
        }

        public Service1Client(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress) {
        }

        public Service1Client(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress) {
        }

        public Service1Client(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        #region IService1 Members

        public string GetData(int value) {
            return base.Channel.GetData(value);
        }

        public StudentDTO[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }

        public bool DeleteStudent(StudentDTO student) {
            return base.Channel.DeleteStudent(student);
        }

        public bool UpdateStudent(StudentDTO student) {
            return base.Channel.UpdateStudent(student);
        }

        public void CreateStudent(StudentDTO student) {
            base.Channel.CreateStudent(student);
        }

        #endregion
    }
}