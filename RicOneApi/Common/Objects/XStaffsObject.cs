﻿using RestSharp;
using RicOneApi.Common.Rest;
using RicOneApi.Models.XPress;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-15
 */
namespace RicOneApi.Common.Objects
{
    /// <summary>
    /// xStaffs Service Paths.
    /// </summary>
    class XStaffsObject
    {
        private RestClient rc;
        private string baseApiUrl;

        /// <summary>
        /// XStaffs Object Constructor.
        /// </summary>
        /// <param name="rc">REST client.</param>
        /// <param name="baseApiUrl">Base API url.</param>
        internal XStaffsObject(RestClient rc, string baseApiUrl)
        {
            this.rc = rc;
            this.baseApiUrl = baseApiUrl;
        }

        /// <summary>
        /// Request all xStaffs.
        /// </summary>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffs()
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffs, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStaffs by school year.
        /// </summary>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffs(int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffs, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStaffs with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffs, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStaffs with paging by school year.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffs, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point.
        /// </summary>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffs(string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffs, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request all xStaffs value changes from a given point with paging.
        /// </summary>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="opaqueMarker">Uses an ISO8601 timestamp that indicates a point since the last changes have been requested.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffs(int? navigationPage, int? navigationPageSize, string opaqueMarker)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter(opaqueMarker);
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffs, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xStaff by refId.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <returns>Single xStaffs type.</returns>
        internal ResponseSingle<XStaffType> GetXStaff(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request single xStaff by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStaffs.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>Single xStaffs type.</returns>
        internal ResponseSingle<XStaffType> GetXStaff(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffByRefId, refId, rh, rqp);
            return rr.MakeSingleRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXLea(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xLea by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xLeas.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXLea(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXLea, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xSchool by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xSchools.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXSchool(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXSchool, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);

        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xCourse by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xCourses.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXCourse(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXCourse, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xRoster by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xRosters.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXRoster(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXRoster, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader();
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId with paging.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? navigationPage, int? navigationPageSize)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }

        /// <summary>
        /// Request xStaffs associated to a specific xStudent by refId with paging by school year.
        /// </summary>
        /// <param name="refId">RefId of xStudents.</param>
        /// <param name="navigationPage">Page to retrieve.</param>
        /// <param name="navigationPageSize">Number of resources to retrieve.</param>
        /// <param name="schoolYear">The year of the requested data (i.e. 2018 for the 2017-2018 school year).</param>
        /// <returns>List of xStaffs type.</returns>
        internal ResponseMulti<XStaffType> GetXStaffsByXStudent(string refId, int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            RestReturn rr = new RestReturn();
            RestHeader rh = new RestHeader(navigationPage, navigationPageSize, schoolYear);
            RestQueryParameter rqp = new RestQueryParameter();
            RestProperties rp = new RestProperties(baseApiUrl, ServicePath.GetXStaffsByXStudent, refId, rh, rqp);
            return rr.MakeAllRequest<XStaffType, XStaffCollectionType>(rc, rp);
        }
    }
}
