using System;


namespace R5T.T0017
{
    /// <summary>
    /// Stringly-typed file system path descriptor.
    /// Note, there is no verification logic for values. This is just a dumb data class. Verification can be performed with a service (TODO).
    /// </summary>
    /// <remarks>
    /// Useful in labeling example file system paths for use in testing a stringly-typed path operator.
    /// </remarks>
    public class PathDescriptor
    {
        #region Static

        public static PathDescriptor NewDirectoryPathDescriptor(string directoryPath,
            RootedOrRelative rootedOrRelative = RootedOrRelative.Rooted, // In common usage, directory paths are usually rooted.
            bool directoryIndicated = false, // In common usage, directory path usually do not end with the directory separator character.
            bool resolved = true) // In common usage, directory paths are usually always resolved.
        {
            var output = new PathDescriptor
            {
                Path = directoryPath,
                DirectoryOrFile = DirectoryOrFile.Directory,
                RootedOrRelative = rootedOrRelative,
                DirectoryIndicated = directoryIndicated,
                Resolved = resolved,
            };
            return output;
        }

        public static PathDescriptor NewFilePathDescriptor(string directoryPath,
            RootedOrRelative rootedOrRelative = RootedOrRelative.Rooted, // In common usage, file paths are usually rooted.
            bool directoryIndicated = false, // File paths really should not end with the directory separator character.
            bool resolved = true) // In common usage, file paths are usually always resolved.
        {
            var output = new PathDescriptor
            {
                Path = directoryPath,
                DirectoryOrFile = DirectoryOrFile.File,
                RootedOrRelative = rootedOrRelative,
                DirectoryIndicated = directoryIndicated,
                Resolved = resolved,
            };
            return output;
        }

        #endregion


        public string Path { get; set; }
        public DirectoryOrFile DirectoryOrFile { get; set; }
        public RootedOrRelative RootedOrRelative { get; set; }
        /// <summary>
        /// Describes whether the path ends with the directory separator character.
        /// </summary>
        /// <remarks>
        /// Not an enumeration since this is unambiguous.
        /// </remarks>
        public bool DirectoryIndicated { get; set; }
        /// <summary>
        /// Describes whether the path has any current directory (".") or parent directory ("..") path parts.
        /// </summary>
        /// <remarks>
        /// Not an enumeration since this is unambiguous.
        /// </remarks>
        public bool Resolved { get; set; }


        public PathDescriptor()
        {
        }
    }
}
