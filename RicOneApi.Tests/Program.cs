﻿/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.2
 * Since       2016-05-11
 * Filename    Program.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Net;
using System.Net.Security;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;

namespace RicOneApi.Tests
{
    class Program
    { 
        #region Test Constants
        const string authUrl = "http://auth.test.ricone.org/login";
        const string clientId = "dpaDemo";
        const string clientSecret = "65ee6dc913d9023f1ee94ab33c3cae38c57";
        const string providerId = "workshop";

        // Null:
        static string refId = null;
        // Lea:
        //static string refId = "1098EFC6-5374-4D7D-AEAE-58E021CCB146";
        //static string refId = "8DC360AF-5FC2-465C-94E4-EB9596F3F7C4";
        // School:
        //static string refId = "0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C";
        //static string refId = "BAC59C6E-D8DD-4E21-938A-13A80E555B7E";
        //static string refId = "106E9449-3FF4-499E-B94F-BCE557C013CE";
        // Calendar:
        //static string refId = "0451AF50-40BA-4231-8656-AE4C28AF7426";
        // Course:
        //static string refId = "A985F5AF-2139-4C5C-B253-00AEE896259E";
        //static string refId = "01810477-3494-4EE8-87C7-19BE2BBDC524";
        // Roster:
        //static string refId = "9AEF7446-1B9F-4C2A-A7FF-0058C51C0E5F";
        //static string refId = "93C3E007-D29E-4096-A58C-645C620EC9B9";
        //	 Staff:
        //static string refId = "DDB25022-B78E-4C89-9A59-AE877E03CFE3";
        //static string refId = "190C1A4B-AD63-469B-BF2B-9673C8AC312A";
        //	 Student:
        //static string refId = "4C4A57D5-ED2F-4AFC-8C20-2A309989ED71";
        //static string refId = "62DF00BD-6A5A-4FE9-AD17-9A03189DAEA5";
        //static string refId = "87B0AA0D-020A-4E0C-9010-AC1F4E315C74";
        // Contact 1:
        //static string refId = "F0BED6E9-8636-4BB3-8295-778D8930B2A1";
        #endregion

        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(authUrl, clientId, clientSecret);
            //Get endpoints by provider
            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                RicOneApiClient ricOne = new RicOneApiClient(e);

                #region xLeas
                //XLeas_GetXLeas(ricOne);
                //XLeas_GetXLea(ricOne);
                //XLeas_GetXLeasByXSchool(ricOne);
                //XLeas_GetXLeasByXRoster(ricOne);
                //XLeas_GetXLeasByXStaff(ricOne);
                //XLeas_GetXLeasByXStudent(ricOne);
                //XLeas_GetXLeasByXContact(ricOne);
                #endregion

                #region xSchools
                //XSchools_GetXSchools(ricOne);
                //XSchools_GetXSchool(ricOne);
                //XSchools_GetXSchoolsByXLea(ricOne);
                //XSchools_GetXSchoolsByXCalendar(ricOne);
                //XSchools_GetXSchoolsByXCourse(ricOne);
                //XSchools_GetXSchoolsByXRoster(ricOne);
                //XSchools_GetXSchoolsByXStaff(ricOne);
                //XSchools_GetXSchoolsByXStudent(ricOne);
                //XSchools_GetXSchoolsByXContact(ricOne);
                #endregion

                #region xCalendars

                //XCalendars_GetXCalendars(ricOne);
                //XCalendars_GetXCalendar(ricOne);
                //XCalendars_GetXCalendarsByXLea(ricOne); 
                //XCalendars_GetXCalendarsByXSchool(ricOne);

                #endregion

                #region xCourses

                //XCourses_GetXCourses(ricOne);
                //XCourses_GetXCourse(ricOne);
                //XCourses_GetXCoursesByXLea(ricOne);
                //XCourses_GetXCoursesByXSchool(ricOne);
                //XCourses_GetXCoursesByXRoster(ricOne);

                #endregion

                #region xRosters

                //XRosters_GetXRosters(ricOne);
                //XRosters_GetXRoster(ricOne);
                //XRosters_GetXRostersByXLea(ricOne);
                //XRosters_GetXRostersByXSchool(ricOne);
                //XRosters_GetXRostersByXCourse(ricOne);
                //XRosters_GetXRostersByXStaff(ricOne);
                //XRosters_GetXRostersByXStudent(ricOne);

                #endregion

                #region xStaffs
                //XStaffs_GetXStaffs(ricOne);
                //XStaffs_GetXStaff(ricOne);
                //XStaffs_GetXStaffsByXLea(ricOne);
                //XStaffs_GetXStaffsByXSchool(ricOne);
                //XStaffs_GetXStaffsByXCourse(ricOne);
                //XStaffs_GetXStaffsByXRoster(ricOne);
                //XStaffs_GetXStaffsByXStudent(ricOne);
                #endregion

                #region xStudents
                //XStudents_GetXStudents(ricOne);
                //XStudents_GetXStudent(ricOne);
                //XStudents_GetXStudentsByXLea(ricOne);
                //XStudents_GetXStudentsByXSchool(ricOne);
                //XStudents_GetXStudentsByXRoster(ricOne);
                //XStudents_GetXStudentsByXStaff(ricOne);
                //XStudents_GetXStudentsByXContact(ricOne);
                #endregion

                #region xContacts
                //XContacts_GetXContacts(ricOne);
                //XContacts_GetXContact(ricOne);
                //XContacts_GetXContactsByXLea(ricOne);
                //XContacts_GetXContactsByXSchool(ricOne);
                //XContacts_GetXContactsByXStudent(ricOne);
                #endregion
            }

            Console.ReadLine();
        }

        #region xLeas

        //RETURN ALL LEAS
        public static void XLeas_GetXLeas(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXLeas().Data != null)
            {
                foreach (XLeaType lea in ricOne.xPress.GetXLeas().Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE LEA
        public static void XLeas_GetXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXLea(refId).Data != null)
            {
                XLeaType lea = ricOne.xPress.GetXLea(refId).Data;
            
                Console.WriteLine("refId: " + lea.refId);
                Console.WriteLine("leaName: " + lea.leaName);
                Console.WriteLine("leaRefId: " + lea.leaRefId);
                Console.WriteLine("localId: " + lea.localId);
                Console.WriteLine("ncesId: " + lea.ncesId);
                Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                Console.WriteLine("##### BEGIN ADDRESS #####");
                Console.WriteLine("addressType: " + lea.address.addressType);
                Console.WriteLine("city: " + lea.address.city);
                Console.WriteLine("line1: " + lea.address.line1);
                Console.WriteLine("line2: " + lea.address.line2);
                Console.WriteLine("countryCode: " + lea.address.countryCode);
                Console.WriteLine("postalCode: " + lea.address.postalCode);
                Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                Console.WriteLine("##### END ADDRESS #####");
                Console.WriteLine("##### BEGIN PHONENUMBER #####");
                Console.WriteLine("number: " + lea.phoneNumber.number);
                Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                Console.WriteLine("##### END PHONENUMBER #####");
                Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                {
                    Console.WriteLine("number: " + p.number);
                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                }
                Console.WriteLine("##### END OTHERPHONENUMBER #####");
                Console.WriteLine("========================================");
            }
        }
        //RETURN LEAS BY SCHOOL
        public static void XLeas_GetXLeasByXSchool(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXLeasByXSchool(refId).Data != null)
            {
                foreach (XLeaType lea in ricOne.xPress.GetXLeasByXSchool(refId).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN LEAS BY ROSTER
        public static void XLeas_GetXLeasByXRoster(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXLeasByXRoster(refId) != null)
            {
                foreach (XLeaType lea in ricOne.xPress.GetXLeasByXRoster(refId).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN LEAS BY STAFF
        public static void XLeas_GetXLeasByXStaff(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXLeasByXStaff(refId) != null)
            {
                foreach (XLeaType lea in ricOne.xPress.GetXLeasByXStaff(refId).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN LEAS BY STUDENT
        public static void XLeas_GetXLeasByXStudent(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXLeasByXStudent(refId).Data != null)
            {
                foreach (XLeaType lea in ricOne.xPress.GetXLeasByXStudent(refId).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN LEAS BY CONTACT
        public static void XLeas_GetXLeasByXContact(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXLeasByXContact(refId) != null)
            {
                foreach (XLeaType lea in ricOne.xPress.GetXLeasByXContact(refId).Data)
                {
                    Console.WriteLine("refId: " + lea.refId);
                    Console.WriteLine("leaName: " + lea.leaName);
                    Console.WriteLine("leaRefId: " + lea.leaRefId);
                    Console.WriteLine("localId: " + lea.localId);
                    Console.WriteLine("ncesId: " + lea.ncesId);
                    Console.WriteLine("stateProvinceId: " + lea.stateProvinceId);

                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + lea.address.addressType);
                    Console.WriteLine("city: " + lea.address.city);
                    Console.WriteLine("line1: " + lea.address.line1);
                    Console.WriteLine("line2: " + lea.address.line2);
                    Console.WriteLine("countryCode: " + lea.address.countryCode);
                    Console.WriteLine("postalCode: " + lea.address.postalCode);
                    Console.WriteLine("stateProvince: " + lea.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + lea.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + lea.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + lea.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in lea.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        
        #endregion

        #region xSchools
        //RETURN ALL SCHOOLS
        public static void XSchools_GetXSchools(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXSchools().Data != null)
            {
                foreach (XSchoolType school in ricOne.xPress.GetXSchools().Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE SCHOOL
        public static void XSchools_GetXSchool(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXSchool(refId).Data != null)
            {
                XSchoolType school = ricOne.xPress.GetXSchool(refId).Data;

                Console.WriteLine("refId: " + school.refId);
                Console.WriteLine("leaRefId: " + school.leaRefId);
                Console.WriteLine("localId: " + school.localId);
                Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                Console.WriteLine("##### BEGIN OTHERIDS #####");
                foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                {
                    Console.WriteLine("otherId id" + id.id);
                    Console.WriteLine("type: " + id.type);
                }
                Console.WriteLine("##### END OTHERIDS #####");
                Console.WriteLine("schoolName: " + school.schoolName);
                Console.WriteLine("##### BEGIN GRADELEVELS #####");
                foreach (String gl in school.gradeLevels.gradeLevel)
                {
                    Console.WriteLine("gradeLevel: " + gl);
                }
                Console.WriteLine("##### END GRADELEVELS #####");
                Console.WriteLine("##### BEGIN ADDRESS #####");
                Console.WriteLine("addressType: " + school.address.addressType);
                Console.WriteLine("city: " + school.address.city);
                Console.WriteLine("line1: " + school.address.line1);
                Console.WriteLine("line2: " + school.address.line2);
                Console.WriteLine("countryCode: " + school.address.countryCode);
                Console.WriteLine("postalCode: " + school.address.postalCode);
                Console.WriteLine("stateProvince: " + school.address.stateProvince);
                Console.WriteLine("##### END ADDRESS #####");
                Console.WriteLine("##### BEGIN PHONENUMBER #####");
                Console.WriteLine("number: " + school.phoneNumber.number);
                Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                Console.WriteLine("##### END PHONENUMBER #####");
                Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                {
                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                }
                Console.WriteLine("##### END OTHERPHONENUMBER #####");
                Console.WriteLine("========================================");
            }
            
        }
        //RETURN SCHOOLS BY LEA
        public static void XSchools_GetXSchoolsByXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXSchoolsByXLea(refId).Data != null)
            {
                foreach (XSchoolType school in ricOne.xPress.GetXSchoolsByXLea(refId).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SCHOOLS BY CALENDAR
        public static void XSchools_GetXSchoolsByXCalendar(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXSchoolsByXCalendar(refId) != null)
            {
                foreach (XSchoolType school in ricOne.xPress.GetXSchoolsByXCalendar(refId).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SCHOOLS BY COURSE
        public static void XSchools_GetXSchoolsByXCourse(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXSchoolsByXCourse(refId).Data != null)
            {
                foreach (XSchoolType school in ricOne.xPress.GetXSchoolsByXCourse(refId).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
         }
        //RETURN SCHOOLS BY ROSTER
        public static void XSchools_GetXSchoolsByXRoster(RicOneApiClient ricOne)
         {
             if (ricOne.xPress.GetXSchoolsByXRoster(refId).Data != null)
             {
                 foreach (XSchoolType school in ricOne.xPress.GetXSchoolsByXRoster(refId).Data)
                 {
                     Console.WriteLine("refId: " + school.refId);
                     Console.WriteLine("leaRefId: " + school.leaRefId);
                     Console.WriteLine("localId: " + school.localId);
                     Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                     Console.WriteLine("##### BEGIN OTHERIDS #####");
                     foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                     {
                         Console.WriteLine("otherId id" + id.id);
                         Console.WriteLine("type: " + id.type);
                     }
                     Console.WriteLine("##### END OTHERIDS #####");
                     Console.WriteLine("schoolName: " + school.schoolName);
                     Console.WriteLine("##### BEGIN GRADELEVELS #####");
                     foreach (String gl in school.gradeLevels.gradeLevel)
                     {
                         Console.WriteLine("gradeLevel: " + gl);
                     }
                     Console.WriteLine("##### END GRADELEVELS #####");
                     Console.WriteLine("##### BEGIN ADDRESS #####");
                     Console.WriteLine("addressType: " + school.address.addressType);
                     Console.WriteLine("city: " + school.address.city);
                     Console.WriteLine("line1: " + school.address.line1);
                     Console.WriteLine("line2: " + school.address.line2);
                     Console.WriteLine("countryCode: " + school.address.countryCode);
                     Console.WriteLine("postalCode: " + school.address.postalCode);
                     Console.WriteLine("stateProvince: " + school.address.stateProvince);
                     Console.WriteLine("##### END ADDRESS #####");
                     Console.WriteLine("##### BEGIN PHONENUMBER #####");
                     Console.WriteLine("number: " + school.phoneNumber.number);
                     Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                     Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                     Console.WriteLine("##### END PHONENUMBER #####");
                     Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                     foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                     {
                         Console.WriteLine("otherPhoneNumbers number: " + p.number);
                         Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                         Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                     }
                     Console.WriteLine("##### END OTHERPHONENUMBER #####");
                     Console.WriteLine("========================================");
                 }
             }
         }
        //RETURN SCHOOLS BY STAFF
        public static void XSchools_GetXSchoolsByXStaff(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXSchoolsByXStaff(refId).Data != null)
            {
                foreach (XSchoolType school in ricOne.xPress.GetXSchoolsByXStaff(refId).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SCHOOLS BY STUDENT
        public static void XSchools_GetXSchoolsByXStudent(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXSchoolsByXStudent(refId).Data != null)
            {
                foreach (XSchoolType school in ricOne.xPress.GetXSchoolsByXStudent(refId).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SCHOOLS BY CONTACT
        public static void XSchools_GetXSchoolsByXContact(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXSchoolsByXContact(refId).Data != null)
            {
                foreach (XSchoolType school in ricOne.xPress.GetXSchoolsByXContact(refId).Data)
                {
                    Console.WriteLine("refId: " + school.refId);
                    Console.WriteLine("leaRefId: " + school.leaRefId);
                    Console.WriteLine("localId: " + school.localId);
                    Console.WriteLine("stateProvinceId: " + school.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherOrganizationIdType id in school.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("schoolName: " + school.schoolName);
                    Console.WriteLine("##### BEGIN GRADELEVELS #####");
                    foreach (String gl in school.gradeLevels.gradeLevel)
                    {
                        Console.WriteLine("gradeLevel: " + gl);
                    }
                    Console.WriteLine("##### END GRADELEVELS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + school.address.addressType);
                    Console.WriteLine("city: " + school.address.city);
                    Console.WriteLine("line1: " + school.address.line1);
                    Console.WriteLine("line2: " + school.address.line2);
                    Console.WriteLine("countryCode: " + school.address.countryCode);
                    Console.WriteLine("postalCode: " + school.address.postalCode);
                    Console.WriteLine("stateProvince: " + school.address.stateProvince);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBER #####");
                    Console.WriteLine("number: " + school.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + school.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + school.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBER #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBER #####");
                    foreach (XTelephoneType p in school.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBER #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        #endregion

        #region xCalendars
        //RETURN ALL CALENDARS
        public static void XCalendars_GetXCalendars(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXCalendars().Data != null)
            {
                foreach (XCalendarType calendar in ricOne.xPress.GetXCalendars().Data)
                {
                    Console.WriteLine("refId: " + calendar.refId);
                    Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
                    Console.WriteLine("schoolYear: " + calendar.schoolYear);
                    Console.WriteLine("##### BEGIN SESSIONLIST #####");
                    foreach (XSessionType sl in calendar.sessions.sessionList)
                    {
                        Console.WriteLine("sessionType: " + sl.sessionType);
                        Console.WriteLine("sessionCode: " + sl.sessionCode);
                        Console.WriteLine("description: " + sl.description);
                        Console.WriteLine("markingTerm: " + sl.markingTerm);
                        Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
                        Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
                        Console.WriteLine("startDate: " + sl.startDate);
                        Console.WriteLine("endDate: " + sl.endDate);
                    }
                    Console.WriteLine("##### END SESSIONLIST #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE CALENDAR
        public static void XCalendars_GetXCalendar(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXCalendar(refId).Data != null)
            {
                XCalendarType calendar = ricOne.xPress.GetXCalendar(refId).Data;

                Console.WriteLine("refId: " + calendar.refId);
                Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
                Console.WriteLine("schoolYear: " + calendar.schoolYear);
                Console.WriteLine("##### BEGIN SESSIONLIST #####");
                foreach (XSessionType sl in calendar.sessions.sessionList)
                {
                    Console.WriteLine("sessionType: " + sl.sessionType);
                    Console.WriteLine("sessionCode: " + sl.sessionCode);
                    Console.WriteLine("description: " + sl.description);
                    Console.WriteLine("markingTerm: " + sl.markingTerm);
                    Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
                    Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
                    Console.WriteLine("startDate: " + sl.startDate);
                    Console.WriteLine("endDate: " + sl.endDate);
                }
                Console.WriteLine("##### END SESSIONLIST #####");
                Console.WriteLine("========================================");
            }
        }
        //RETURN CALENDARS BY LEA
        public static void XCalendars_GetXCalendarsByXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXCalendarsByXLea(refId).Data != null)
            {
                foreach (XCalendarType calendar in ricOne.xPress.GetXCalendarsByXLea(refId).Data)
                {
                    Console.WriteLine("refId: " + calendar.refId);
                    Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
                    Console.WriteLine("schoolYear: " + calendar.schoolYear);
                    Console.WriteLine("##### BEGIN SESSIONLIST #####");
                    foreach (XSessionType sl in calendar.sessions.sessionList)
                    {
                        Console.WriteLine("sessionType: " + sl.sessionType);
                        Console.WriteLine("sessionCode: " + sl.sessionCode);
                        Console.WriteLine("description: " + sl.description);
                        Console.WriteLine("markingTerm: " + sl.markingTerm);
                        Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
                        Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
                        Console.WriteLine("startDate: " + sl.startDate);
                        Console.WriteLine("endDate: " + sl.endDate);
                    }
                    Console.WriteLine("##### END SESSIONLIST #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN CALENDARS BY SCHOOL
        public static void XCalendars_GetXCalendarsByXSchool(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXCalendarsByXSchool(refId).Data != null)
            {
                foreach (XCalendarType calendar in ricOne.xPress.GetXCalendarsByXSchool(refId).Data)
                {
                    Console.WriteLine("refId: " + calendar.refId);
                    Console.WriteLine("schoolRefId: " + calendar.schoolRefId);
                    Console.WriteLine("schoolYear: " + calendar.schoolYear);
                    Console.WriteLine("##### BEGIN SESSIONLIST #####");
                    foreach (XSessionType sl in calendar.sessions.sessionList)
                    {
                        Console.WriteLine("sessionType: " + sl.sessionType);
                        Console.WriteLine("sessionCode: " + sl.sessionCode);
                        Console.WriteLine("description: " + sl.description);
                        Console.WriteLine("markingTerm: " + sl.markingTerm);
                        Console.WriteLine("schedulingTerm: " + sl.schedulingTerm);
                        Console.WriteLine("linkedSessionCode: " + sl.linkedSessionCode);
                        Console.WriteLine("startDate: " + sl.startDate);
                        Console.WriteLine("endDate: " + sl.endDate);
                    }
                    Console.WriteLine("##### END SESSIONLIST #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        #endregion

        #region xCourses
        //RETURN ALL COURSES
        public static void XCourses_GetXCourses(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXCourses().Data != null)
            {
                foreach(XCourseType course in ricOne.xPress.GetXCourses().Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####"); 
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE COURSE
        public static void XCourses_GetXCourse(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXCourse(refId).Data != null)
            {
                XCourseType course = ricOne.xPress.GetXCourse(refId).Data;
            
                Console.WriteLine("refId: " + course.refId);
                Console.WriteLine("schoolRefId: " + course.schoolRefId);
                Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                Console.WriteLine("leaCourseId: " + course.leaCourseId);
                Console.WriteLine("##### BEGIN OTHERIDS #####");
                foreach (XOtherCourseIdType id in course.otherIds.otherId)
                {
                    Console.WriteLine("otherId id" + id.id);
                    Console.WriteLine("type: " + id.type);
                }
                Console.WriteLine("##### END OTHERIDS #####");
                Console.WriteLine("courseTitle: " + course.courseTitle);
                Console.WriteLine("description: " + course.description);
                Console.WriteLine("subject: " + course.subject);
                Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                {
                    Console.WriteLine("applicableEducationLevel: " + ael);
                }
                Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                Console.WriteLine("========================================");
            }
        }
        //RETURN COURSES BY LEA
        public static void XCourses_GetXCoursesByXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXCoursesByXLea(refId).Data != null)
            {
                foreach (XCourseType course in ricOne.xPress.GetXCoursesByXLea(refId).Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN COURSES BY SCHOOL
        public static void XCourses_GetXCoursesByXSchool(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXCoursesByXSchool(refId).Data != null)
            {
                foreach (XCourseType course in ricOne.xPress.GetXCoursesByXSchool(refId).Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN COURSES BY ROSTER
        public static void XCourses_GetXCoursesByXRoster(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXCoursesByXRoster(refId) != null)
            {
                foreach (XCourseType course in ricOne.xPress.GetXCoursesByXRoster(refId).Data)
                {
                    Console.WriteLine("refId: " + course.refId);
                    Console.WriteLine("schoolRefId: " + course.schoolRefId);
                    Console.WriteLine("schoolCourseId: " + course.schoolCourseId);
                    Console.WriteLine("leaCourseId: " + course.leaCourseId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherCourseIdType id in course.otherIds.otherId)
                    {
                        Console.WriteLine("otherId id" + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("courseTitle: " + course.courseTitle);
                    Console.WriteLine("description: " + course.description);
                    Console.WriteLine("subject: " + course.subject);
                    Console.WriteLine("##### BEGIN APPLICABLEEDUCATIONLEVELS #####");
                    foreach (String ael in course.applicableEducationLevels.applicableEducationLevel)
                    {
                        Console.WriteLine("applicableEducationLevel: " + ael);
                    }
                    Console.WriteLine("##### END APPLICABLEEDUCATIONLEVELS #####");
                    Console.WriteLine("scedCourseCode: " + course.scedCourseCode);
                    Console.WriteLine("scedCourseLevelCode: " + course.scedCourseLevelCode);
                    Console.WriteLine("scedCourseSubjectAreaCode: " + course.scedCourseSubjectAreaCode);

                    Console.WriteLine("========================================");
                }
            }
        }
        #endregion

        #region xRosters
        //RETURN ALL ROSTERS
        public static void XRosters_GetXRosters(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXRosters().Data != null)
            {
                foreach (XRosterType r in ricOne.xPress.GetXRosters().Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);

                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE ROSTER
        public static void XRosters_GetXRoster(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXRoster(refId).Data != null)
            {
                XRosterType r = ricOne.xPress.GetXRoster(refId).Data;

                Console.WriteLine("refId: " + r.refId);
                Console.WriteLine("courseRefId: " + r.courseRefId);
                Console.WriteLine("courseTitle: " + r.courseTitle);
                Console.WriteLine("sectionRefId: " + r.sectionRefId);
                Console.WriteLine("subject: " + r.subject);
                Console.WriteLine("schoolRefId: " + r.schoolRefId);
                Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                Console.WriteLine("schoolYear: " + r.schoolYear);
                Console.WriteLine("sessionCode: " + r.sessionCode);
                Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                Console.WriteLine("##### BEGIN MEETING TIMES #####");
                foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                {
                    Console.WriteLine("timeTableDay: " + mt.timeTableDay);

                    Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                    Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                    Console.WriteLine("roomNumber: " + mt.roomNumber);
                    Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                    Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                }
                Console.WriteLine("##### END MEETING TIMES #####");

                Console.WriteLine("##### BEGIN STUDENTS #####");
                foreach (XPersonReferenceType student in r.students.studentReference)
                {
                    Console.WriteLine("refId: " + student.refId);
                    Console.WriteLine("localId: " + student.localId);
                    Console.WriteLine("givenName: " + student.givenName);
                    Console.WriteLine("familyName: " + student.familyName);
                }
                Console.WriteLine("##### END STUDENTS #####");

                Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                Console.WriteLine("##### END PRIMARY STAFF #####");

                Console.WriteLine("##### BEGIN OTHER STAFF #####");
                foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                {
                    Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                }
                Console.WriteLine("##### END OTHER STAFF #####");
                Console.WriteLine("========================================");
            }
        }
        //RETURN ROSTERS BY LEA
        public static void XRosters_GetXRostersByXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXRostersByXLea(refId).Data != null)
            {
                foreach (XRosterType r in ricOne.xPress.GetXRostersByXLea(refId).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);

                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN ROSTERS BY SCHOOL
        public static void XRosters_GetXRostersByXSchool(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXRostersByXSchool(refId).Data != null)
            {
                foreach (XRosterType r in ricOne.xPress.GetXRostersByXSchool(refId).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);

                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN ROSTERS BY CROUSE
        public static void XRosters_GetXRostersByXCourse(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXRostersByXCourse(refId).Data != null)
            {
                foreach (XRosterType r in ricOne.xPress.GetXRostersByXCourse(refId).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);

                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN ROSTERS BY STAFF
        public static void XRosters_GetXRostersByXStaff(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXRostersByXStaff(refId).Data != null)
            {
                foreach (XRosterType r in ricOne.xPress.GetXRostersByXStaff(refId).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);

                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN ROSTERS BY STUDENT
        public static void XRosters_GetXRostersByXStudent(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXRostersByXStudent(refId).Data != null)
            {
                foreach (XRosterType r in ricOne.xPress.GetXRostersByXStudent(refId).Data)
                {
                    Console.WriteLine("refId: " + r.refId);
                    Console.WriteLine("courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);
                    Console.WriteLine("sectionRefId: " + r.sectionRefId);
                    Console.WriteLine("subject: " + r.subject);
                    Console.WriteLine("schoolRefId: " + r.schoolRefId);
                    Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
                    Console.WriteLine("schoolYear: " + r.schoolYear);
                    Console.WriteLine("sessionCode: " + r.sessionCode);
                    Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

                    Console.WriteLine("##### BEGIN MEETING TIMES #####");
                    foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("timeTableDay: " + mt.timeTableDay);

                        Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + mt.roomNumber);
                        Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
                        Console.WriteLine("classEndingTime: " + mt.classEndingTime);
                    }
                    Console.WriteLine("##### END MEETING TIMES #####");

                    Console.WriteLine("##### BEGIN STUDENTS #####");
                    foreach (XPersonReferenceType student in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + student.refId);
                        Console.WriteLine("localId: " + student.localId);
                        Console.WriteLine("givenName: " + student.givenName);
                        Console.WriteLine("familyName: " + student.familyName);
                    }
                    Console.WriteLine("##### END STUDENTS #####");

                    Console.WriteLine("##### BEGIN PRIMARY STAFF #####");
                    Console.WriteLine("refId: " + r.primaryStaff.staffPersonReference.refId);
                    Console.WriteLine("localId: " + r.primaryStaff.staffPersonReference.localId);
                    Console.WriteLine("givenName: " + r.primaryStaff.staffPersonReference.givenName);
                    Console.WriteLine("familyName: " + r.primaryStaff.staffPersonReference.familyName);
                    Console.WriteLine("teacherOfRecord: " + r.primaryStaff.teacherOfRecord);
                    Console.WriteLine("percentResponsible: " + r.primaryStaff.percentResponsible);
                    Console.WriteLine("##### END PRIMARY STAFF #####");

                    Console.WriteLine("##### BEGIN OTHER STAFF #####");
                    foreach (XStaffReferenceType staff in r.otherStaffs.otherStaff)
                    {
                        Console.WriteLine("refId: " + staff.staffPersonReference.refId);
                        Console.WriteLine("localId: " + staff.staffPersonReference.localId);
                        Console.WriteLine("givenName: " + staff.staffPersonReference.givenName);
                        Console.WriteLine("familyName: " + staff.staffPersonReference.familyName);
                        Console.WriteLine("teacherOfRecord: " + staff.teacherOfRecord);
                        Console.WriteLine("percentResponsible: " + staff.percentResponsible);
                    }
                    Console.WriteLine("##### END OTHER STAFF #####");
                    Console.WriteLine("========================================");
                }
            }
        }

        #endregion

        #region xStaffs
        //RETURN ALL STAFFS
        public static void XStaffs_GetXStaffs(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStaffs().Data != null)
            {
                foreach (XStaffType s in ricOne.xPress.GetXStaffs().Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);
                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE STAFF
        public static void XStaffs_GetXStaff(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXStaff(refId).Data != null)
            {
                XStaffType s = ricOne.xPress.GetXStaff(refId).Data;

                Console.WriteLine("refId: " + s.refId);
                Console.WriteLine("##### BEGIN NAME #####");
                Console.WriteLine("type: " + s.name.type);
                Console.WriteLine("prefix: " + s.name.prefix);
                Console.WriteLine("familyName: " + s.name.familyName);
                Console.WriteLine("givenName: " + s.name.givenName);
                Console.WriteLine("middleName: " + s.name.middleName);
                Console.WriteLine("suffix: " + s.name.suffix);
                Console.WriteLine("##### END NAME #####");
                Console.WriteLine("localId: " + s.localId);

                Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                Console.WriteLine("##### BEGIN OTHERIDS #####");
                foreach (XOtherPersonIdType id in s.otherIds.otherId)
                {
                    Console.WriteLine("id: " + id.id);
                    Console.WriteLine("type: " + id.type);
                }
                Console.WriteLine("##### END OTHERIDS #####");
                Console.WriteLine("sex: " + s.sex);
                Console.WriteLine("##### BEGIN EMAIL #####");
                Console.WriteLine("emailType: " + s.email.emailType);
                Console.WriteLine("emailAddress: " + s.email.emailAddress);
                Console.WriteLine("##### END EMAIL #####");
                Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                {
                    Console.WriteLine("leaRefId: " + pa.leaRefId);
                    Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                    Console.WriteLine("jobFunction: " + pa.jobFunction);
                }
                Console.WriteLine("##### END OTHERASSIGNMENT #####");
                Console.WriteLine("========================================");
            }
        }
        //RETURN STAFFS BY LEA
        public static void XStaffs_GetXStaffsByXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStaffsByXLea(refId).Data != null)
            {
                foreach (XStaffType s in ricOne.xPress.GetXStaffsByXLea(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STAFFS BY SCHOOL
        public static void XStaffs_GetXStaffsByXSchool(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStaffsByXSchool(refId).Data != null)
            {
                foreach (XStaffType s in ricOne.xPress.GetXStaffsByXSchool(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STAFFS BY COURSE
        public static void XStaffs_GetXStaffsByXCourse(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStaffsByXCourse(refId).Data != null)
            {
                foreach (XStaffType s in ricOne.xPress.GetXStaffsByXCourse(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STAFFS BY ROSTER
        public static void XStaffs_GetXStaffsByXRoster(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStaffsByXRoster(refId).Data != null)
            {
                foreach (XStaffType s in ricOne.xPress.GetXStaffsByXRoster(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STAFFS BY STUDENT
        public static void XStaffs_GetXStaffsByXStudent(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStaffsByXStudent(refId).Data != null)
            {
                foreach (XStaffType s in ricOne.xPress.GetXStaffsByXStudent(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("sex: " + s.sex);
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN PRIMARYASSIGNMENT #####");
                    Console.WriteLine("leaRefId: " + s.primaryAssignment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.primaryAssignment.schoolRefId);
                    Console.WriteLine("jobFunction: " + s.primaryAssignment.jobFunction);
                    Console.WriteLine("##### END PRIMARYASSIGNMENT #####");
                    Console.WriteLine("##### BEGIN OTHERASSIGNMENT #####");
                    foreach (XStaffPersonAssignmentType pa in s.otherAssignments.staffPersonAssignment)
                    {
                        Console.WriteLine("leaRefId: " + pa.leaRefId);
                        Console.WriteLine("schoolRefId: " + pa.schoolRefId);
                        Console.WriteLine("jobFunction: " + pa.jobFunction);
                    }
                    Console.WriteLine("##### END OTHERASSIGNMENT #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        #endregion

        #region xStudents
        //RETURN ALL STUDENTS
        public static void XStudents_GetXStudents(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStudents().Data != null)
            {
                foreach (XStudentType s in ricOne.xPress.GetXStudents().Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        Console.WriteLine("exitDate: " + e.exitDate);
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE STUDENT
        public static void XStudents_GetXStudent(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXStudent(refId).Data != null)
            {
                XStudentType s = ricOne.xPress.GetXStudent(refId).Data;

                Console.WriteLine("refId: " + s.refId);
                Console.WriteLine("##### BEGIN NAME #####");
                Console.WriteLine("type: " + s.name.type);
                Console.WriteLine("prefix: " + s.name.prefix);
                Console.WriteLine("familyName: " + s.name.familyName);
                Console.WriteLine("givenName: " + s.name.givenName);
                Console.WriteLine("middleName: " + s.name.middleName);
                Console.WriteLine("suffix: " + s.name.suffix);
                Console.WriteLine("##### END NAME #####");
                Console.WriteLine("##### BEGIN OTHERNAME #####");
                foreach (XPersonNameType n in s.otherNames.name)
                {
                    Console.WriteLine("type: " + n.type);
                    Console.WriteLine("prefix: " + n.prefix);
                    Console.WriteLine("familyName: " + n.familyName);
                    Console.WriteLine("givenName: " + n.givenName);
                    Console.WriteLine("middleName: " + n.middleName);
                    Console.WriteLine("suffix: " + n.suffix);
                }
                Console.WriteLine("##### END OTHERNAME #####");

                Console.WriteLine("localId: " + s.localId);

                Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                Console.WriteLine("##### BEGIN OTHERIDS #####");
                foreach (XOtherPersonIdType id in s.otherIds.otherId)
                {
                    Console.WriteLine("id: " + id.id);
                    Console.WriteLine("type: " + id.type);
                }
                Console.WriteLine("##### END OTHERIDS #####");
                Console.WriteLine("##### BEGIN ADDRESS #####");
                Console.WriteLine("addressType: " + s.address.addressType);
                Console.WriteLine("city: " + s.address.city);
                Console.WriteLine("line1: " + s.address.line1);
                Console.WriteLine("line2: " + s.address.line2);
                Console.WriteLine("countryCode: " + s.address.countryCode);
                Console.WriteLine("postalCode: " + s.address.postalCode);
                Console.WriteLine("stateProvince: " + s.address.stateProvince);
                Console.WriteLine("number: " + s.phoneNumber.number);
                Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                Console.WriteLine("##### END ADDRESS #####");
                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                Console.WriteLine("number: " + s.phoneNumber.number);
                Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                Console.WriteLine("##### END PHONENUMBERS #####");
                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                {
                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                }
                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                Console.WriteLine("##### BEGIN EMAIL #####");
                Console.WriteLine("emailType: " + s.email.emailType);
                Console.WriteLine("emailAddress: " + s.email.emailAddress);
                Console.WriteLine("##### END EMAIL #####");
                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                foreach (XEmailType e in s.otherEmails.email)
                {
                    Console.WriteLine("emailType: " + e.emailType);
                    Console.WriteLine("emailAddress: " + e.emailAddress);
                }
                Console.WriteLine("##### END OTHEREMAILS #####");
                Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                Console.WriteLine("##### BEGIN RACES #####");
                foreach (XRaceType r in s.demographics.races.race)
                {
                    Console.WriteLine("race: " + r.race);
                }
                Console.WriteLine("##### END RACES #####");
                Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                Console.WriteLine("sex: " + s.demographics.sex);
                Console.WriteLine("birthDate: " + s.demographics.birthDate);
                Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                Console.WriteLine("##### END DEMOGRAPHICS #####");
                Console.WriteLine("##### BEGIN ENROLLMENT #####");
                Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                Console.WriteLine("##### END HOMEROOMTEACHER #####");
                Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                Console.WriteLine("##### BEGIN COUNSELOR #####");
                Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                Console.WriteLine("##### END COUNSELOR #####");
                Console.WriteLine("##### END ENROLLMENT #####");
                Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                {
                    Console.WriteLine("leaRefId: " + e.leaRefId);
                    Console.WriteLine("schoolRefId: " + e.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + e.membershipType);
                    Console.WriteLine("entryDate: " + e.entryDate);
                    Console.WriteLine("exitDate: " + e.exitDate);
                    Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + e.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + e.counselor.refId);
                    Console.WriteLine("localId: " + e.counselor.localId);
                    Console.WriteLine("givenName: " + e.counselor.givenName);
                    Console.WriteLine("familyName: " + e.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                }
                Console.WriteLine("##### END OTHERENROLLMENT #####");
                Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                Console.WriteLine("classRank: " + s.academicSummary.classRank);
                Console.WriteLine("##### END ACADEMICSUMMARY #####");
                Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                {
                    Console.WriteLine("contactPersonRefId: " + contactRefid);
                }
                foreach (XContactType c in s.studentContacts.xContact)
                {
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");
                    Console.WriteLine(": " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine(": " + c.sex);
                    Console.WriteLine(": " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                }
                Console.WriteLine("##### END STUDENTCONTACTS #####");
                Console.WriteLine("##### BEGIN LANGUAGES #####");
                foreach (XLanguageType l in s.languages.language)
                {
                    Console.WriteLine("type: " + l.type);
                    Console.WriteLine("code: " + l.code);
                }
                Console.WriteLine("##### END LANGUAGES #####");
                Console.WriteLine("========================================");
            }
        }
        //RETURN STUDENTS BY LEA
        public static void XStudents_GetXStudentsByXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStudentsByXLea(refId).Data != null)
            {
                foreach (XStudentType s in ricOne.xPress.GetXStudentsByXLea(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        Console.WriteLine("exitDate: " + e.exitDate);
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STUDENTS BY SCHOOL
        public static void XStudents_GetXStudentsByXSchool(RicOneApiClient ricOne) 
        {
            if (ricOne.xPress.GetXStudentsByXSchool(refId).Data != null)
            {
                foreach (XStudentType s in ricOne.xPress.GetXStudentsByXSchool(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        Console.WriteLine("exitDate: " + e.exitDate);
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STUDENTS BY ROSTER
        public static void XStudents_GetXStudentsByXRoster(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStudentsByXRoster(refId).Data != null)
            {
                foreach (XStudentType s in ricOne.xPress.GetXStudentsByXRoster(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        Console.WriteLine("exitDate: " + e.exitDate);
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STUDENTS BY STAFF
        public static void XStudents_GetXStudentsByXStaff(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStudentsByXStaff(refId).Data != null)
            {
                foreach (XStudentType s in ricOne.xPress.GetXStudentsByXStaff(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        Console.WriteLine("exitDate: " + e.exitDate);
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN STUDENTS BY CONTACT
        public static void XStudents_GetXStudentsByXContact(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXStudentsByXContact(refId).Data != null)
            {
                foreach (XStudentType s in ricOne.xPress.GetXStudentsByXContact(refId).Data)
                {
                    Console.WriteLine("refId: " + s.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + s.name.type);
                    Console.WriteLine("prefix: " + s.name.prefix);
                    Console.WriteLine("familyName: " + s.name.familyName);
                    Console.WriteLine("givenName: " + s.name.givenName);
                    Console.WriteLine("middleName: " + s.name.middleName);
                    Console.WriteLine("suffix: " + s.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in s.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + s.localId);

                    Console.WriteLine("stateProvinceIdloginId: " + s.stateProvinceId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in s.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + s.address.addressType);
                    Console.WriteLine("city: " + s.address.city);
                    Console.WriteLine("line1: " + s.address.line1);
                    Console.WriteLine("line2: " + s.address.line2);
                    Console.WriteLine("countryCode: " + s.address.countryCode);
                    Console.WriteLine("postalCode: " + s.address.postalCode);
                    Console.WriteLine("stateProvince: " + s.address.stateProvince);
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + s.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + s.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + s.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in s.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + s.email.emailType);
                    Console.WriteLine("emailAddress: " + s.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in s.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("##### BEGIN DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN RACES #####");
                    foreach (XRaceType r in s.demographics.races.race)
                    {
                        Console.WriteLine("race: " + r.race);
                    }
                    Console.WriteLine("##### END RACES #####");
                    Console.WriteLine("hispanicLatinoEthnicity: " + s.demographics.hispanicLatinoEthnicity);
                    Console.WriteLine("sex: " + s.demographics.sex);
                    Console.WriteLine("birthDate: " + s.demographics.birthDate);
                    Console.WriteLine("countryOfBirth: " + s.demographics.countryOfBirth);
                    Console.WriteLine("usCitizenshipStatus: " + s.demographics.usCitizenshipStatus);
                    Console.WriteLine("##### END DEMOGRAPHICS #####");
                    Console.WriteLine("##### BEGIN ENROLLMENT #####");
                    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
                    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
                    Console.WriteLine("studentSchoolAssociationRefId: " + s.enrollment.studentSchoolAssociationRefId);
                    Console.WriteLine("responsibleSchoolType: " + s.enrollment.responsibleSchoolType);
                    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
                    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
                    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
                    Console.WriteLine("homeRoomNumber: " + s.enrollment.homeRoomNumber);
                    Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                    Console.WriteLine("refId: " + s.enrollment.homeRoomTeacher.refId);
                    Console.WriteLine("localId: " + s.enrollment.homeRoomTeacher.localId);
                    Console.WriteLine("givenName: " + s.enrollment.homeRoomTeacher.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.homeRoomTeacher.familyName);
                    Console.WriteLine("##### END HOMEROOMTEACHER #####");
                    Console.WriteLine("gradeLevel: " + s.enrollment.gradeLevel);
                    Console.WriteLine("projectedGraduationYear: " + s.enrollment.projectedGraduationYear);
                    Console.WriteLine("##### BEGIN COUNSELOR #####");
                    Console.WriteLine("refId: " + s.enrollment.counselor.refId);
                    Console.WriteLine("localId: " + s.enrollment.counselor.localId);
                    Console.WriteLine("givenName: " + s.enrollment.counselor.givenName);
                    Console.WriteLine("familyName: " + s.enrollment.counselor.familyName);
                    Console.WriteLine("##### END COUNSELOR #####");
                    Console.WriteLine("##### END ENROLLMENT #####");
                    Console.WriteLine("##### BEGIN OTHERENROLLMENT #####");
                    foreach (XEnrollmentType e in s.otherEnrollments.enrollment)
                    {
                        Console.WriteLine("leaRefId: " + e.leaRefId);
                        Console.WriteLine("schoolRefId: " + e.schoolRefId);
                        Console.WriteLine("studentSchoolAssociationRefId: " + e.studentSchoolAssociationRefId);
                        Console.WriteLine("responsibleSchoolType: " + e.responsibleSchoolType);
                        Console.WriteLine("membershipType: " + e.membershipType);
                        Console.WriteLine("entryDate: " + e.entryDate);
                        Console.WriteLine("exitDate: " + e.exitDate);
                        Console.WriteLine("homeRoomNumber: " + e.homeRoomNumber);
                        Console.WriteLine("##### BEGIN HOMEROOMTEACHER #####");
                        Console.WriteLine("refId: " + e.homeRoomTeacher.refId);
                        Console.WriteLine("localId: " + e.homeRoomTeacher.localId);
                        Console.WriteLine("givenName: " + e.homeRoomTeacher.givenName);
                        Console.WriteLine("familyName: " + e.homeRoomTeacher.familyName);
                        Console.WriteLine("##### END HOMEROOMTEACHER #####");
                        Console.WriteLine("gradeLevel: " + e.gradeLevel);
                        Console.WriteLine("projectedGraduationYear: " + e.projectedGraduationYear);
                        Console.WriteLine("##### BEGIN COUNSELOR #####");
                        Console.WriteLine("refId: " + e.counselor.refId);
                        Console.WriteLine("localId: " + e.counselor.localId);
                        Console.WriteLine("givenName: " + e.counselor.givenName);
                        Console.WriteLine("familyName: " + e.counselor.familyName);
                        Console.WriteLine("##### END COUNSELOR #####");
                    }
                    Console.WriteLine("##### END OTHERENROLLMENT #####");
                    Console.WriteLine("##### BEGIN ACADEMICSUMMARY #####");
                    Console.WriteLine("cumulativeWeightedGpa: " + s.academicSummary.cumulativeWeightedGpa);
                    Console.WriteLine("termWeightedGpa: " + s.academicSummary.termWeightedGpa);
                    Console.WriteLine("classRank: " + s.academicSummary.classRank);
                    Console.WriteLine("##### END ACADEMICSUMMARY #####");
                    Console.WriteLine("##### BEGIN STUDENTCONTACTS #####");
                    foreach (String contactRefid in s.studentContacts.contactPersonRefId)
                    {
                        Console.WriteLine("contactPersonRefId: " + contactRefid);
                    }
                    foreach (XContactType c in s.studentContacts.xContact)
                    {
                        Console.WriteLine("##### BEGIN NAME #####");
                        Console.WriteLine("type: " + c.name.type);
                        Console.WriteLine("prefix: " + c.name.prefix);
                        Console.WriteLine("familyName: " + c.name.familyName);
                        Console.WriteLine("givenName: " + c.name.givenName);
                        Console.WriteLine("middleName: " + c.name.middleName);
                        Console.WriteLine("suffix: " + c.name.suffix);
                        Console.WriteLine("##### END NAME #####");
                        Console.WriteLine("##### BEGIN OTHERNAME #####");
                        foreach (XPersonNameType n in c.otherNames.name)
                        {
                            Console.WriteLine("type: " + n.type);
                            Console.WriteLine("prefix: " + n.prefix);
                            Console.WriteLine("familyName: " + n.familyName);
                            Console.WriteLine("givenName: " + n.givenName);
                            Console.WriteLine("middleName: " + n.middleName);
                            Console.WriteLine("suffix: " + n.suffix);
                        }
                        Console.WriteLine("##### END OTHERNAME #####");
                        Console.WriteLine(": " + c.localId);

                        Console.WriteLine("##### BEGIN OTHERIDS #####");
                        foreach (XOtherPersonIdType id in c.otherIds.otherId)
                        {
                            Console.WriteLine("id: " + id.id);
                            Console.WriteLine("type: " + id.type);
                        }
                        Console.WriteLine("##### END OTHERIDS #####");
                        Console.WriteLine("##### BEGIN ADDRESS #####");
                        Console.WriteLine("addressType: " + c.address.addressType);
                        Console.WriteLine("city: " + c.address.city);
                        Console.WriteLine("line1: " + c.address.line1);
                        Console.WriteLine("line2: " + c.address.line2);
                        Console.WriteLine("countryCode: " + c.address.countryCode);
                        Console.WriteLine("postalCode: " + c.address.postalCode);
                        Console.WriteLine("stateProvince: " + c.address.stateProvince);
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END ADDRESS #####");
                        Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                        Console.WriteLine("number: " + c.phoneNumber.number);
                        Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                        Console.WriteLine("##### END PHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                        foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                        {
                            Console.WriteLine("otherPhoneNumbers number: " + p.number);
                            Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                            Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                        }
                        Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                        Console.WriteLine("##### BEGIN EMAIL #####");
                        Console.WriteLine("emailType: " + c.email.emailType);
                        Console.WriteLine("emailAddress: " + c.email.emailAddress);
                        Console.WriteLine("##### END EMAIL #####");
                        Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                        foreach (XEmailType e in c.otherEmails.email)
                        {
                            Console.WriteLine("emailType: " + e.emailType);
                            Console.WriteLine("emailAddress: " + e.emailAddress);
                        }
                        Console.WriteLine("##### END OTHEREMAILS #####");
                        Console.WriteLine(": " + c.sex);
                        Console.WriteLine(": " + c.employerType);
                        Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                        foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                        {
                            Console.WriteLine("studentRefId: " + csr.studentRefId);
                            Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                            Console.WriteLine("restrictions: " + csr.restrictions);
                            Console.WriteLine("livesWith: " + csr.livesWith);
                            Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                            Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                            Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                            Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                            Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                            Console.WriteLine("contactSequence: " + csr.contactSequence);
                        }
                        Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    }
                    Console.WriteLine("##### END STUDENTCONTACTS #####");
                    Console.WriteLine("##### BEGIN LANGUAGES #####");
                    foreach (XLanguageType l in s.languages.language)
                    {
                        Console.WriteLine("type: " + l.type);
                        Console.WriteLine("code: " + l.code);
                    }
                    Console.WriteLine("##### END LANGUAGES #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        #endregion

        #region xContacts
        //RETURN ALL CONTACTS
        public static void XContacts_GetXContacts(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXContacts().Data != null)
            {
                foreach (XContactType c in ricOne.xPress.GetXContacts().Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);
                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN SINGLE CONTACT
        public static void XContacts_GetXContact(RicOneApiClient ricOne)
        {
            if(ricOne.xPress.GetXContact(refId).Data != null)
            {
                XContactType c = ricOne.xPress.GetXContact(refId).Data;

                Console.WriteLine("refId: " + c.refId);
                Console.WriteLine("##### BEGIN NAME #####");
                Console.WriteLine("type: " + c.name.type);
                Console.WriteLine("prefix: " + c.name.prefix);
                Console.WriteLine("familyName: " + c.name.familyName);
                Console.WriteLine("givenName: " + c.name.givenName);
                Console.WriteLine("middleName: " + c.name.middleName);
                Console.WriteLine("suffix: " + c.name.suffix);
                Console.WriteLine("##### END NAME #####");
                Console.WriteLine("##### BEGIN OTHERNAME #####");
                foreach (XPersonNameType n in c.otherNames.name)
                {
                    Console.WriteLine("type: " + n.type);
                    Console.WriteLine("prefix: " + n.prefix);
                    Console.WriteLine("familyName: " + n.familyName);
                    Console.WriteLine("givenName: " + n.givenName);
                    Console.WriteLine("middleName: " + n.middleName);
                    Console.WriteLine("suffix: " + n.suffix);
                }
                Console.WriteLine("##### END OTHERNAME #####");

                Console.WriteLine("localId: " + c.localId);

                Console.WriteLine("##### BEGIN OTHERIDS #####");
                foreach (XOtherPersonIdType id in c.otherIds.otherId)
                {
                    Console.WriteLine("id: " + id.id);
                    Console.WriteLine("type: " + id.type);
                }
                Console.WriteLine("##### END OTHERIDS #####");
                Console.WriteLine("##### BEGIN ADDRESS #####");
                Console.WriteLine("addressType: " + c.address.addressType);
                Console.WriteLine("city: " + c.address.city);
                Console.WriteLine("line1: " + c.address.line1);
                Console.WriteLine("line2: " + c.address.line2);
                Console.WriteLine("countryCode: " + c.address.countryCode);
                Console.WriteLine("postalCode: " + c.address.postalCode);
                Console.WriteLine("stateProvince: " + c.address.stateProvince);
                Console.WriteLine("number: " + c.phoneNumber.number);
                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                Console.WriteLine("##### END ADDRESS #####");
                Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                Console.WriteLine("number: " + c.phoneNumber.number);
                Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                Console.WriteLine("##### END PHONENUMBERS #####");
                Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                {
                    Console.WriteLine("otherPhoneNumbers number: " + p.number);
                    Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                }
                Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                Console.WriteLine("##### BEGIN EMAIL #####");
                Console.WriteLine("emailType: " + c.email.emailType);
                Console.WriteLine("emailAddress: " + c.email.emailAddress);
                Console.WriteLine("##### END EMAIL #####");
                Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                foreach (XEmailType e in c.otherEmails.email)
                {
                    Console.WriteLine("emailType: " + e.emailType);
                    Console.WriteLine("emailAddress: " + e.emailAddress);
                }
                Console.WriteLine("##### END OTHEREMAILS #####");
                Console.WriteLine("sex: " + c.sex);
                Console.WriteLine("employerType: " + c.employerType);
                Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                {
                    Console.WriteLine("studentRefId: " + csr.studentRefId);
                    Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                    Console.WriteLine("restrictions: " + csr.restrictions);
                    Console.WriteLine("livesWith: " + csr.livesWith);
                    Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                    Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                    Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                    Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                    Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                    Console.WriteLine("contactSequence: " + csr.contactSequence);
                }
                Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                Console.WriteLine("========================================");
            }
        }
        //RETURN CONTACTS BY LEA
        public static void XContacts_GetXContactsByXLea(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXContactsByXLea(refId).Data != null)
            {
                foreach (XContactType c in ricOne.xPress.GetXContactsByXLea(refId).Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN CONTACTS BY SCHOOL
        public static void XContacts_GetXContactsByXSchool(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXContactsByXSchool(refId).Data != null)
            {
                foreach (XContactType c in ricOne.xPress.GetXContactsByXSchool(refId).Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        //RETURN CONTACTS BY STUDENT
        public static void XContacts_GetXContactsByXStudent(RicOneApiClient ricOne)
        {
            if (ricOne.xPress.GetXContactsByXStudent(refId).Data != null)
            {
                foreach (XContactType c in ricOne.xPress.GetXContactsByXStudent(refId).Data)
                {
                    Console.WriteLine("refId: " + c.refId);
                    Console.WriteLine("##### BEGIN NAME #####");
                    Console.WriteLine("type: " + c.name.type);
                    Console.WriteLine("prefix: " + c.name.prefix);
                    Console.WriteLine("familyName: " + c.name.familyName);
                    Console.WriteLine("givenName: " + c.name.givenName);
                    Console.WriteLine("middleName: " + c.name.middleName);
                    Console.WriteLine("suffix: " + c.name.suffix);
                    Console.WriteLine("##### END NAME #####");
                    Console.WriteLine("##### BEGIN OTHERNAME #####");
                    foreach (XPersonNameType n in c.otherNames.name)
                    {
                        Console.WriteLine("type: " + n.type);
                        Console.WriteLine("prefix: " + n.prefix);
                        Console.WriteLine("familyName: " + n.familyName);
                        Console.WriteLine("givenName: " + n.givenName);
                        Console.WriteLine("middleName: " + n.middleName);
                        Console.WriteLine("suffix: " + n.suffix);
                    }
                    Console.WriteLine("##### END OTHERNAME #####");

                    Console.WriteLine("localId: " + c.localId);

                    Console.WriteLine("##### BEGIN OTHERIDS #####");
                    foreach (XOtherPersonIdType id in c.otherIds.otherId)
                    {
                        Console.WriteLine("id: " + id.id);
                        Console.WriteLine("type: " + id.type);
                    }
                    Console.WriteLine("##### END OTHERIDS #####");
                    Console.WriteLine("##### BEGIN ADDRESS #####");
                    Console.WriteLine("addressType: " + c.address.addressType);
                    Console.WriteLine("city: " + c.address.city);
                    Console.WriteLine("line1: " + c.address.line1);
                    Console.WriteLine("line2: " + c.address.line2);
                    Console.WriteLine("countryCode: " + c.address.countryCode);
                    Console.WriteLine("postalCode: " + c.address.postalCode);
                    Console.WriteLine("stateProvince: " + c.address.stateProvince);
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END ADDRESS #####");
                    Console.WriteLine("##### BEGIN PHONENUMBERS #####");
                    Console.WriteLine("number: " + c.phoneNumber.number);
                    Console.WriteLine("phoneNumberType: " + c.phoneNumber.phoneNumberType);
                    Console.WriteLine("primaryIndicator: " + c.phoneNumber.primaryIndicator);
                    Console.WriteLine("##### END PHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN OTHERPHONENUMBERS #####");
                    foreach (XTelephoneType p in c.otherPhoneNumbers.phoneNumber)
                    {
                        Console.WriteLine("otherPhoneNumbers number: " + p.number);
                        Console.WriteLine("phoneNumberType: " + p.phoneNumberType);
                        Console.WriteLine("primaryIndicator: " + p.primaryIndicator);
                    }
                    Console.WriteLine("##### END OTHERPHONENUMBERS #####");
                    Console.WriteLine("##### BEGIN EMAIL #####");
                    Console.WriteLine("emailType: " + c.email.emailType);
                    Console.WriteLine("emailAddress: " + c.email.emailAddress);
                    Console.WriteLine("##### END EMAIL #####");
                    Console.WriteLine("##### BEGIN OTHEREMAILS #####");
                    foreach (XEmailType e in c.otherEmails.email)
                    {
                        Console.WriteLine("emailType: " + e.emailType);
                        Console.WriteLine("emailAddress: " + e.emailAddress);
                    }
                    Console.WriteLine("##### END OTHEREMAILS #####");
                    Console.WriteLine("sex: " + c.sex);
                    Console.WriteLine("employerType: " + c.employerType);
                    Console.WriteLine("##### BEGIN CONTACTRELATIONSHIPS #####");
                    foreach (XContactStudentRelationshipType csr in c.relationships.relationship)
                    {
                        Console.WriteLine("studentRefId: " + csr.studentRefId);
                        Console.WriteLine("relationshipCode: " + csr.relationshipCode);
                        Console.WriteLine("restrictions: " + csr.restrictions);
                        Console.WriteLine("livesWith: " + csr.livesWith);
                        Console.WriteLine("primaryContactIndicator: " + csr.primaryContactIndicator);
                        Console.WriteLine("emergencyContactIndicator: " + csr.emergencyContactIndicator);
                        Console.WriteLine("financialResponsibilityIndicator: " + csr.financialResponsibilityIndicator);
                        Console.WriteLine("custodialIndicator: " + csr.custodialIndicator);
                        Console.WriteLine("communicationsIndicator: " + csr.communicationsIndicator);
                        Console.WriteLine("contactSequence: " + csr.contactSequence);
                    }
                    Console.WriteLine("##### END CONTACTRELATIONSHIPS #####");
                    Console.WriteLine("========================================");
                }
            }
        }
        #endregion
    }
}
