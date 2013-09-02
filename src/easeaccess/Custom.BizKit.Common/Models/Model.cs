﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom.Models
{
    public class Model
    {   
        private List<Text> _title;
        private List<Text> _summary;
        private List<Field> _fields;
        private DateTime? _createdOn;
        private string _createdBy;

        public string Name
        {
            get;
            set;
        }

        public List<Text> Title
        {
            get { return _title ?? (_title = new List<Text>()); }
            set { _title = value; }
        }

        public List<Text> Summary
        {
            get { return _summary ?? (_summary = new List<Text>()); }
            set { _summary = value; }
        }

        public List<Field> Fields
        {
            get { return _fields ?? (_fields = new List<Field>()); }
            set { _fields = value; }
        }

        public DateTime CreatedOn
        {
            get { return (DateTime)(_createdOn ?? (_createdOn = DateTime.UtcNow)); }
            set { _createdOn = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy ?? (_createdBy = "system"); }
            set { _createdBy = value; }
        }

        public DateTime? ModifiedOn
        {
            get;
            set;
        }

        public string ModifiedBy
        {
            get;
            set;
        }
    }
}