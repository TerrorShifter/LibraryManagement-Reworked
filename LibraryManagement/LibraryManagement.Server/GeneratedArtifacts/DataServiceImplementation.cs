﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Book> BookSearchQuery()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Book> query;
            query = global::System.Linq.Queryable.ThenBy(
                global::System.Linq.Queryable.ThenBy(
                    global::System.Linq.Queryable.ThenBy(
                        global::System.Linq.Queryable.OrderBy(
                            this.GetQuery<global::LightSwitchApplication.Implementation.Book>("Books"),
                            (b) => b.Author),
                        (b) => b.Title),
                    (b) => b.Series),
                (b) => b.BookNumber);
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Patron))
            {
                return new global::LightSwitchApplication.Implementation.Patron();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Book))
            {
                return new global::LightSwitchApplication.Implementation.Book();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Fee))
            {
                return new global::LightSwitchApplication.Implementation.Fee();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.CheckOut))
            {
                return new global::LightSwitchApplication.Implementation.CheckOut();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Patron))
            {
                return new global::LightSwitchApplication.Implementation.Patron();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Book))
            {
                return new global::LightSwitchApplication.Implementation.Book();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Fee))
            {
                return new global::LightSwitchApplication.Implementation.Fee();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.CheckOut))
            {
                return new global::LightSwitchApplication.Implementation.CheckOut();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Patron) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Patron);
            }
            if (typeof(global::LightSwitchApplication.Book) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Book);
            }
            if (typeof(global::LightSwitchApplication.Fee) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Fee);
            }
            if (typeof(global::LightSwitchApplication.CheckOut) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.CheckOut);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Patron :
        global::LightSwitchApplication.Patron.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Patron.DetailsClass.IImplementation.Book
        {
            get
            {
                return this.Book;
            }
            set
            {
                this.Book = (global::LightSwitchApplication.Implementation.Book)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Book");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Patron.DetailsClass.IImplementation.Fees
        {
            get
            {
                return this.Fees;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Patron.DetailsClass.IImplementation.CheckOuts
        {
            get
            {
                return this.CheckOuts;
            }
        }
        
        partial void OnPatron_BookChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Book");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Book :
        global::LightSwitchApplication.Book.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Book.DetailsClass.IImplementation.Patrons
        {
            get
            {
                return this.Patrons;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Book.DetailsClass.IImplementation.CheckOut
        {
            get
            {
                return this.CheckOut;
            }
            set
            {
                this.CheckOut = (global::LightSwitchApplication.Implementation.CheckOut)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("CheckOut");
                }
            }
        }
        
        partial void OnCheckOut_BookChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("CheckOut");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Fee :
        global::LightSwitchApplication.Fee.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Fee.DetailsClass.IImplementation.Patron
        {
            get
            {
                return this.Patron;
            }
            set
            {
                this.Patron = (global::LightSwitchApplication.Implementation.Patron)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Patron");
                }
            }
        }
        
        partial void OnPatron_FeeChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Patron");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class CheckOut :
        global::LightSwitchApplication.CheckOut.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.CheckOut.DetailsClass.IImplementation.Books
        {
            get
            {
                return this.Books;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.CheckOut.DetailsClass.IImplementation.Patron
        {
            get
            {
                return this.Patron;
            }
            set
            {
                this.Patron = (global::LightSwitchApplication.Implementation.Patron)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Patron");
                }
            }
        }
        
        partial void OnCheckOut_PatronChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Patron");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

