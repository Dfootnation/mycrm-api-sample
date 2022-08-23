// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    /// <summary> The ContactAttributes. </summary>
    public partial class ContactAttributes
    {
        /// <summary> Initializes a new instance of ContactAttributes. </summary>
        public ContactAttributes()
        {
        }

        /// <summary> Initializes a new instance of ContactAttributes. </summary>
        /// <param name="created"></param>
        /// <param name="mobile"></param>
        /// <param name="title"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="preferredName"></param>
        /// <param name="homePhone"></param>
        /// <param name="businessPhone"></param>
        /// <param name="email"></param>
        /// <param name="secondaryEmail"></param>
        /// <param name="gender"></param>
        /// <param name="updated"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="isPrimary"></param>
        /// <param name="role"></param>
        /// <param name="hasMarketingConsent"></param>
        internal ContactAttributes(DateTimeOffset? created, string mobile, string title, string firstName, string middleName, string lastName, string preferredName, string homePhone, string businessPhone, string email, string secondaryEmail, ContactAttributesGender? gender, DateTimeOffset? updated, DateTimeOffset? dateOfBirth, bool? isPrimary, ContactAttributesRole? role, bool? hasMarketingConsent)
        {
            Created = created;
            Mobile = mobile;
            Title = title;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PreferredName = preferredName;
            HomePhone = homePhone;
            BusinessPhone = businessPhone;
            Email = email;
            SecondaryEmail = secondaryEmail;
            Gender = gender;
            Updated = updated;
            DateOfBirth = dateOfBirth;
            IsPrimary = isPrimary;
            Role = role;
            HasMarketingConsent = hasMarketingConsent;
        }

        /// <summary> Gets the created. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> Gets or sets the mobile. </summary>
        public string Mobile { get; set; }
        /// <summary> Gets or sets the title. </summary>
        public string Title { get; set; }
        /// <summary> Gets or sets the first name. </summary>
        public string FirstName { get; set; }
        /// <summary> Gets or sets the middle name. </summary>
        public string MiddleName { get; set; }
        /// <summary> Gets or sets the last name. </summary>
        public string LastName { get; set; }
        /// <summary> Gets or sets the preferred name. </summary>
        public string PreferredName { get; set; }
        /// <summary> Gets or sets the home phone. </summary>
        public string HomePhone { get; set; }
        /// <summary> Gets or sets the business phone. </summary>
        public string BusinessPhone { get; set; }
        /// <summary> Gets or sets the email. </summary>
        public string Email { get; set; }
        /// <summary> Gets or sets the secondary email. </summary>
        public string SecondaryEmail { get; set; }
        /// <summary> Gets or sets the gender. </summary>
        public ContactAttributesGender? Gender { get; set; }
        /// <summary> Gets the updated. </summary>
        public DateTimeOffset? Updated { get; }
        /// <summary> Gets or sets the date of birth. </summary>
        public DateTimeOffset? DateOfBirth { get; set; }
        /// <summary> Gets or sets the is primary. </summary>
        public bool? IsPrimary { get; set; }
        /// <summary> Gets the role. </summary>
        public ContactAttributesRole? Role { get; }
        /// <summary> Gets or sets the has marketing consent. </summary>
        public bool? HasMarketingConsent { get; set; }
    }
}