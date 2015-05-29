using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology
{
    public struct VersionInfo : IComparable, IComparable<VersionInfo>, IEquatable<VersionInfo>
    {
        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public Int32 Major
        {
            get { return major; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Minor
        {
            get { return minor; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Revision
        {
            get { return revision; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Build
        {
            get { return build; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="major"></param>
        /// <param name="minor"></param>
        /// <param name="revision"></param>
        /// <param name="build"></param>
        public VersionInfo(Int32 major, Int32 minor, Int32 revision, Int32 build)
        {
            this.major = major;
            this.minor = minor;
            this.revision = revision;
            this.build = build;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode()
        {
            Int32 accumulator = 0;

            accumulator |= (this.Major & 0x0000000F) << 28;
            accumulator |= (this.Minor & 0x000000FF) << 20;
            accumulator |= (this.Revision & 0x00000FFF) << 12;
            accumulator |= (this.Build & 0x000000FF);

            return accumulator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj)
        {
            if (obj is VersionInfo == false)
                return false;
            return this.Equals((VersionInfo)obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return String.Format("{0}.{1}.{2}.{3}", Major, Minor, Revision, Build);
        }

        #endregion

        #region IComparable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Int32 CompareTo(Object obj)
        {
            if (obj is VersionInfo == false)
                throw new ArgumentNullException("obj");
            return this.CompareTo((VersionInfo)obj);
        }

        #endregion

        #region IComparable<VersionInfo>

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Int32 CompareTo(VersionInfo other)
        {
            if (this.Major != other.Major)
                if (this.Major > other.Major)
                    return 1;
                else
                    return -1;

            if (this.Minor != other.Minor)
                if (this.Minor > other.Minor)
                    return 1;
                else
                    return -1;

            if (this.Revision != other.Revision)
                if (this.Revision > other.Revision)
                    return 1;
                else
                    return -1;

            if (this.Build != other.Build)
                if (this.Build > other.Build)
                    return 1;
                else
                    return -1;

            return 0;
        }

        #endregion

        #region IEquatable<VersionInfo>

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(VersionInfo other)
        {
            if ((this.Major != other.Major) ||
                (this.Minor != other.Minor) ||
                (this.Revision != other.Revision) ||
                (this.Build != other.Build))
                return false;

            return true;
        }

        #endregion

        #region Operators

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Boolean operator ==(VersionInfo v1, VersionInfo v2)
        {
            return v1.Equals(v2) == true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Boolean operator !=(VersionInfo v1, VersionInfo v2)
        {
            return v1.Equals(v2) == false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Boolean operator <(VersionInfo v1, VersionInfo v2)
        {
            return v1.CompareTo(v2) < 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Boolean operator <=(VersionInfo v1, VersionInfo v2)
        {
            return v1.CompareTo(v2) <= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Boolean operator >(VersionInfo v1, VersionInfo v2)
        {
            return v1.CompareTo(v2) > 0;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Boolean operator >=(VersionInfo v1, VersionInfo v2)
        {
            return v1.CompareTo(v2) >= 0;
        }

        #endregion

        #region Private Fields

        private Int32 major, minor, revision, build;

        #endregion
    }
}
