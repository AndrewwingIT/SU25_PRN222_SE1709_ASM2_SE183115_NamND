﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DrugPrevention.Repositories.NamND.Models;

public partial class ProgramParticipantsToanN
{
    public int ParticipantToanNSID { get; set; }

    public int ProgramToanNSID { get; set; }

    public int UserID { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string AttendanceStatus { get; set; }

    public bool? FeedbackProvided { get; set; }

    public int? FeedbackRating { get; set; }

    public bool? CertificateIssued { get; set; }

    public string ParticipantRole { get; set; }

    public string FeedbackComments { get; set; }

    public virtual CommunityProgramsToanN ProgramToanNS { get; set; }

    public virtual UsersTuyenTM User { get; set; }
}