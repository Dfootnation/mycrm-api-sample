// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The LeadEmployment. </summary>
    public partial class LeadEmployment
    {
        /// <summary> Initializes a new instance of LeadEmployment. </summary>
        public LeadEmployment()
        {
        }

        /// <summary> Initializes a new instance of LeadEmployment. </summary>
        /// <param name="lid"></param>
        /// <param name="employmentStatus"></param>
        /// <param name="employmentType"></param>
        /// <param name="dateStartedAsString"></param>
        /// <param name="dateStarted"></param>
        /// <param name="dateEndedAsString"></param>
        /// <param name="dateEnded"></param>
        /// <param name="employmentRoleName"></param>
        /// <param name="employmentBasis"></param>
        /// <param name="isProbation"></param>
        /// <param name="businessNumber"></param>
        /// <param name="companyNumber"></param>
        /// <param name="employerName"></param>
        /// <param name="employerContactTitle"></param>
        /// <param name="employerContactFirstName"></param>
        /// <param name="employerContactLastName"></param>
        /// <param name="employerType"></param>
        /// <param name="employerPhone"></param>
        /// <param name="address"></param>
        internal LeadEmployment(string lid, EmploymentStatus? employmentStatus, EmploymentType? employmentType, DateTimeOffset? dateStartedAsString, DateTimeOffset? dateStarted, DateTimeOffset? dateEndedAsString, DateTimeOffset? dateEnded, string employmentRoleName, EmploymentBasis? employmentBasis, bool? isProbation, string businessNumber, string companyNumber, string employerName, Title? employerContactTitle, string employerContactFirstName, string employerContactLastName, EmployerType? employerType, string employerPhone, LeadAddressReference address)
        {
            Lid = lid;
            EmploymentStatus = employmentStatus;
            EmploymentType = employmentType;
            DateStartedAsString = dateStartedAsString;
            DateStarted = dateStarted;
            DateEndedAsString = dateEndedAsString;
            DateEnded = dateEnded;
            EmploymentRoleName = employmentRoleName;
            EmploymentBasis = employmentBasis;
            IsProbation = isProbation;
            BusinessNumber = businessNumber;
            CompanyNumber = companyNumber;
            EmployerName = employerName;
            EmployerContactTitle = employerContactTitle;
            EmployerContactFirstName = employerContactFirstName;
            EmployerContactLastName = employerContactLastName;
            EmployerType = employerType;
            EmployerPhone = employerPhone;
            Address = address;
        }

        /// <summary> Gets or sets the lid. </summary>
        public string Lid { get; set; }
        /// <summary> Gets or sets the employment status. </summary>
        public EmploymentStatus? EmploymentStatus { get; set; }
        /// <summary> Gets or sets the employment type. </summary>
        public EmploymentType? EmploymentType { get; set; }
        /// <summary> Gets or sets the date started as string. </summary>
        public DateTimeOffset? DateStartedAsString { get; set; }
        /// <summary> Gets or sets the date started. </summary>
        public DateTimeOffset? DateStarted { get; set; }
        /// <summary> Gets or sets the date ended as string. </summary>
        public DateTimeOffset? DateEndedAsString { get; set; }
        /// <summary> Gets or sets the date ended. </summary>
        public DateTimeOffset? DateEnded { get; set; }
        /// <summary> Gets or sets the employment role name. </summary>
        public string EmploymentRoleName { get; set; }
        /// <summary> Gets or sets the employment basis. </summary>
        public EmploymentBasis? EmploymentBasis { get; set; }
        /// <summary> Gets or sets the is probation. </summary>
        public bool? IsProbation { get; set; }
        /// <summary> Gets or sets the business number. </summary>
        public string BusinessNumber { get; set; }
        /// <summary> Gets or sets the company number. </summary>
        public string CompanyNumber { get; set; }
        /// <summary> Gets or sets the employer name. </summary>
        public string EmployerName { get; set; }
        /// <summary> Gets or sets the employer contact title. </summary>
        public Title? EmployerContactTitle { get; set; }
        /// <summary> Gets or sets the employer contact first name. </summary>
        public string EmployerContactFirstName { get; set; }
        /// <summary> Gets or sets the employer contact last name. </summary>
        public string EmployerContactLastName { get; set; }
        /// <summary> Gets or sets the employer type. </summary>
        public EmployerType? EmployerType { get; set; }
        /// <summary> Gets or sets the employer phone. </summary>
        public string EmployerPhone { get; set; }
        /// <summary> Gets or sets the address. </summary>
        public LeadAddressReference Address { get; set; }
    }
}