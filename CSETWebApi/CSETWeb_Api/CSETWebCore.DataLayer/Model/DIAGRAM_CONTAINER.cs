﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSETWebCore.DataLayer
{
    /// <summary>
    /// A collection of DIAGRAM_CONTAINER records
    /// </summary>
    public partial class DIAGRAM_CONTAINER
    {
        public DIAGRAM_CONTAINER()
        {
            ASSESSMENT_DIAGRAM_COMPONENTSLayer_ = new HashSet<ASSESSMENT_DIAGRAM_COMPONENTS>();
            ASSESSMENT_DIAGRAM_COMPONENTSZone_ = new HashSet<ASSESSMENT_DIAGRAM_COMPONENTS>();
            InverseParent_ = new HashSet<DIAGRAM_CONTAINER>();
        }

        [Key]
        public int Container_Id { get; set; }
        [Required]
        [StringLength(50)]
        public string ContainerType { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        public bool? Visible { get; set; }
        [Required]
        [StringLength(50)]
        public string DrawIO_id { get; set; }
        public int Assessment_Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Universal_Sal_Level { get; set; }
        public int Parent_Id { get; set; }
        [StringLength(50)]
        public string Parent_Draw_IO_Id { get; set; }

        [ForeignKey(nameof(ContainerType))]
        [InverseProperty(nameof(DIAGRAM_CONTAINER_TYPES.DIAGRAM_CONTAINER))]
        public virtual DIAGRAM_CONTAINER_TYPES ContainerTypeNavigation { get; set; }
        [ForeignKey(nameof(Parent_Id))]
        [InverseProperty(nameof(DIAGRAM_CONTAINER.InverseParent_))]
        public virtual DIAGRAM_CONTAINER Parent_ { get; set; }
        [InverseProperty(nameof(ASSESSMENT_DIAGRAM_COMPONENTS.Layer_))]
        public virtual ICollection<ASSESSMENT_DIAGRAM_COMPONENTS> ASSESSMENT_DIAGRAM_COMPONENTSLayer_ { get; set; }
        [InverseProperty(nameof(ASSESSMENT_DIAGRAM_COMPONENTS.Zone_))]
        public virtual ICollection<ASSESSMENT_DIAGRAM_COMPONENTS> ASSESSMENT_DIAGRAM_COMPONENTSZone_ { get; set; }
        [InverseProperty(nameof(DIAGRAM_CONTAINER.Parent_))]
        public virtual ICollection<DIAGRAM_CONTAINER> InverseParent_ { get; set; }
    }
}