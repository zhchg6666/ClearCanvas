#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Enterprise.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class ArchiveStudyStorage: ServerEntity
    {
        #region Constructors
        public ArchiveStudyStorage():base("ArchiveStudyStorage")
        {}
        public ArchiveStudyStorage(
             ServerEntityKey _partitionArchiveKey_
            ,ServerEntityKey _studyStorageKey_
            ,ServerEntityKey _serverTransferSyntaxKey_
            ,DateTime _archiveTime_
            ,XmlDocument _archiveXml_
            ):base("ArchiveStudyStorage")
        {
            PartitionArchiveKey = _partitionArchiveKey_;
            StudyStorageKey = _studyStorageKey_;
            ServerTransferSyntaxKey = _serverTransferSyntaxKey_;
            ArchiveTime = _archiveTime_;
            ArchiveXml = _archiveXml_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="ArchiveStudyStorage", ColumnName="PartitionArchiveGUID")]
        public ServerEntityKey PartitionArchiveKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ArchiveStudyStorage", ColumnName="StudyStorageGUID")]
        public ServerEntityKey StudyStorageKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ArchiveStudyStorage", ColumnName="ServerTransferSyntaxGUID")]
        public ServerEntityKey ServerTransferSyntaxKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ArchiveStudyStorage", ColumnName="ArchiveTime")]
        public DateTime ArchiveTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ArchiveStudyStorage", ColumnName="ArchiveXml")]
        public XmlDocument ArchiveXml
        { get { return _ArchiveXml; } set { _ArchiveXml = value; } }
        [NonSerialized]
        private XmlDocument _ArchiveXml;
        #endregion

        #region Static Methods
        static public ArchiveStudyStorage Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public ArchiveStudyStorage Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IArchiveStudyStorageEntityBroker>();
            ArchiveStudyStorage theObject = broker.Load(key);
            return theObject;
        }
        static public ArchiveStudyStorage Insert(ArchiveStudyStorage entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                ArchiveStudyStorage newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public ArchiveStudyStorage Insert(IUpdateContext update, ArchiveStudyStorage entity)
        {
            var broker = update.GetBroker<IArchiveStudyStorageEntityBroker>();
            var updateColumns = new ArchiveStudyStorageUpdateColumns();
            updateColumns.PartitionArchiveKey = entity.PartitionArchiveKey;
            updateColumns.StudyStorageKey = entity.StudyStorageKey;
            updateColumns.ServerTransferSyntaxKey = entity.ServerTransferSyntaxKey;
            updateColumns.ArchiveTime = entity.ArchiveTime;
            updateColumns.ArchiveXml = entity.ArchiveXml;
            ArchiveStudyStorage newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
