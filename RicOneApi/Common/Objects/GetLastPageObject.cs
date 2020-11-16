﻿using RestSharp;
using RicOneApi.Authentication;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;
using System;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.9.0
 * Since       11/13/2020
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// Get the last page of xObject service paths.
    /// </summary>
    [Obsolete("As of version 1.8.0.")]
    class GetLastPageObject
    {
        private RestClient rc;
        private Endpoint endpoint;

        /// <summary>
        /// GetLastPage Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="endpoint">Endpoint object.</param>
        [Obsolete("As of version 1.8.0.")]
        internal GetLastPageObject(RestClient rc, Endpoint endpoint)
        {
            this.rc = rc;
            this.endpoint = endpoint;
        }

        /// <summary>
        /// Returns the max page value for specified service path object.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>Integer value.</returns>
        [Obsolete("As of version 1.8.0, use GetHeaders().NavigationLastPage.")]
        internal int GetLastPage(ServicePath servicePath, int? navigationPageSize)
        {
            int navigationPage = 1;
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();

            try
            {
                switch (servicePath.GetServicePathName())
                {
                    case "GetXLeas":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXLeas, rh, rqp);
                            rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXSchools":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXSchools, rh, rqp);
                            rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCalendars":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXCalendars, rh, rqp);
                            rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCourses":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXCourses, rh, rqp);
                            rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXRosters":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXRosters, rh, rqp);
                            rr.MakeAllRequest<XRosterType, XRosterCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStaffs":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXStaffs, rh, rqp);
                            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStudents":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXStudents, rh, rqp);
                            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXContacts":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXContacts, rh, rqp);
                            rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
                            break;
                        }
                }
                return rr.NavigationLastPage;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns the max page value for specified service path object by school year.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Integer value.</returns>
        [Obsolete("As of version 1.8.0, use GetHeaders().NavigationLastPage.")]
        internal int GetLastPage(ServicePath servicePath, int? navigationPageSize, int? schoolYear)
        {
            int navigationPage = 1;
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            
            try
            {
                switch (servicePath.GetServicePathName())
                {
                    case "GetXLeas":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXLeas, rh, rqp);
                            rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXSchools":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXSchools, rh, rqp);
                            rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCalendars":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXCalendars, rh, rqp);
                            rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCourses":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXCourses, rh, rqp);
                            rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXRosters":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXRosters, rh, rqp);
                            rr.MakeAllRequest<XRosterType, XRosterCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStaffs":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXStaffs, rh, rqp);
                            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStudents":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXStudents, rh, rqp);
                            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXContacts":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXContacts, rh, rqp);
                            rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
                            break;
                        }
                }
                return rr.NavigationLastPage;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns the max page value for specified service path object from a given point.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>Integer value.</returns>
        [Obsolete("As of version 1.8.0, use GetHeaders().NavigationLastPage.")]
        internal int GetLastPage(ServicePath servicePath, int? navigationPageSize, string opaqueMarker)
        {
            int navigationPage = 1;
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);

            try
            {
                switch (servicePath.GetServicePathName())
                {
                    case "GetXLeas":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXLeas, rh, rqp);
                            rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXSchools":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXSchools, rh, rqp);
                            rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCalendars":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXCalendars, rh, rqp);
                            rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCourses":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXCourses, rh, rqp);
                            rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXRosters":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXRosters, rh, rqp);
                            rr.MakeAllRequest<XRosterType, XRosterCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStaffs":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXStaffs, rh, rqp);
                            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStudents":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXStudents, rh, rqp);
                            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXContacts":
                        {
                            RestProperties rp = new RestProperties(endpoint, ServicePath.GetXContacts, rh, rqp);
                            rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
                            break;
                        }
                }
                return rr.NavigationLastPage;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns the max page value for specified service path object.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="refId">RefId of xObject.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>Integer value.</returns>
        [Obsolete("As of version 1.8.0, use GetHeaders().NavigationLastPage.")]
        internal int GetLastPage(ServicePath servicePath, string refId, int? navigationPageSize)
        {
            int navigationPage = 1;
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();

            try
            {
                switch (servicePath.GetServicePathName())
                {
                    case "GetXLeasByXSchool":
                    case "GetXLeasByXRoster":
                    case "GetXLeasByXStaff":
                    case "GetXLeasByXStudent":
                    case "GetXLeasByXContact":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXSchoolsByXLea":
                    case "GetXSchoolsByXCalendar":
                    case "GetXSchoolsByXCourse":
                    case "GetXSchoolsByXRoster":
                    case "GetXSchoolsByXStaff":
                    case "GetXSchoolsByXStudent":
                    case "GetXSchoolsByXContact":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCalendarsByXLea":
                    case "GetXCalendarsByXSchool":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCoursesByXLea":
                    case "GetXCoursesByXSchool":
                    case "GetXCoursesByXRoster":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXRostersByXLea":
                    case "GetXRostersByXSchool":
                    case "GetXRostersByXCourse":
                    case "GetXRostersByXStaff":
                    case "GetXRostersByXStudent":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XRosterType, XRosterCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStaffsByXLea":
                    case "GetXStaffsByXSchool":
                    case "GetXStaffsByXCourse":
                    case "GetXStaffsByXRoster":
                    case "GetXStaffsByXStudent":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStudentsByXLea":
                    case "GetXStudentsByXSchool":
                    case "GetXStudentsByXRoster":
                    case "GetXStudentsByXStaff":
                    case "GetXStudentsByXContact":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXContactsByXLea":
                    case "GetXContactsByXSchool":
                    case "GetXContactsByXStudent":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
                            break;
                        }
                }
                return rr.NavigationLastPage;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns the max page value for specified service path object.
        /// </summary>
        /// <param name="servicePath">The requested service path.</param>
        /// <param name="refId">RefId of xObject.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Integer value.</returns>
        [Obsolete("As of version 1.8.0, use GetHeaders().NavigationLastPage.")]
        internal int GetLastPage(ServicePath servicePath, string refId, int? navigationPageSize, int? schoolYear)
        {
            int navigationPage = 1;
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();

            try
            {
                switch (servicePath.GetServicePathName())
                {
                    case "GetXLeasByXSchool":
                    case "GetXLeasByXRoster":
                    case "GetXLeasByXStaff":
                    case "GetXLeasByXStudent":
                    case "GetXLeasByXContact":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XLeaType, XLeaCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXSchoolsByXLea":
                    case "GetXSchoolsByXCalendar":
                    case "GetXSchoolsByXCourse":
                    case "GetXSchoolsByXRoster":
                    case "GetXSchoolsByXStaff":
                    case "GetXSchoolsByXStudent":
                    case "GetXSchoolsByXContact":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XSchoolType, XSchoolCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCalendarsByXLea":
                    case "GetXCalendarsByXSchool":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XCalendarType, XCalendarCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXCoursesByXLea":
                    case "GetXCoursesByXSchool":
                    case "GetXCoursesByXRoster":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XCourseType, XCourseCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXRostersByXLea":
                    case "GetXRostersByXSchool":
                    case "GetXRostersByXCourse":
                    case "GetXRostersByXStaff":
                    case "GetXRostersByXStudent":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XRosterType, XRosterCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStaffsByXLea":
                    case "GetXStaffsByXSchool":
                    case "GetXStaffsByXCourse":
                    case "GetXStaffsByXRoster":
                    case "GetXStaffsByXStudent":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXStudentsByXLea":
                    case "GetXStudentsByXSchool":
                    case "GetXStudentsByXRoster":
                    case "GetXStudentsByXStaff":
                    case "GetXStudentsByXContact":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XStudentType, XStudentCollectionType>(rc, rp);
                            break;
                        }
                    case "GetXContactsByXLea":
                    case "GetXContactsByXSchool":
                    case "GetXContactsByXStudent":
                        {
                            RestProperties rp = new RestProperties(endpoint, servicePath, refId, rh, rqp);
                            rr.MakeAllRequest<XContactType, XContactCollectionType>(rc, rp);
                            break;
                        }
                }
                return rr.NavigationLastPage;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
