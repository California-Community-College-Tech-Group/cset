﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSETWebCore.DataLayer.Model;

public partial class MALCOLM_MAPPING
{
    [Key]
    public int Malcolm_Id { get; set; }

    public int Question_Or_Requirement_Id { get; set; }

    public int Rule_Violated { get; set; }

    public bool Is_Standard { get; set; }

    public bool Is_Component { get; set; }

    public bool Is_Maturity { get; set; }

    public int? Mat_Option_Id { get; set; }

}