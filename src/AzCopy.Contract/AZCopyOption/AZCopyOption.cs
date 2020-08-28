namespace AzCopy.Contract
{
    public class AZCopyOption : CommandArgsBase
    {
        /// <summary>
        /// Defines the type of blob at the destination. This is used for uploading blobs and when copying between accounts (default 'Detect'). Valid values include 'Detect', 'BlockBlob', 'PageBlob', and 'AppendBlob'. When copying between accounts, a value of 'Detect' causes AzCopy to use the type of source blob to determine the type of the destination blob. When uploading a file, 'Detect' determines if the file is a VHD or a VHDX file based on the file extension. If the file is ether a VHD or VHDX file, AzCopy treats the file as a page blob. (default "Detect")
        /// </summary>
        [CLIArgumentName("blob-type", true)]
        public string BlobType { get; set; }

        /// <summary>
        /// upload block blob to Azure Storage using this blob tier. (default "None").
        /// </summary>
        [CLIArgumentName("block-blob-tier", true)]
        public string BlockBlobTier { get; set; }

        /// <summary>
        /// Use this block size (specified in MiB) when uploading to Azure Storage, and downloading from Azure Storage. The default value is automatically calculated based on file size. Decimal fractions are allowed (For example: 0.25).
        /// </summary>
        [CLIArgumentName("block-size-mb")]
        public float? BlockSizeMb { get; set; }

        /// <summary>
        /// Set the cache-control header. Returned on download.
        /// </summary>
        [CLIArgumentName("cache-control", true)]
        public string CacheControl { get; set; }

        /// <summary>
        /// Check the length of a file on the destination after the transfer. If there is a mismatch between source and destination, the transfer is marked as failed. (default true).
        /// </summary>
        [CLIArgumentName("check-length", false)]
        public bool? CheckLength { get; set; }

        /// <summary>
        /// Specifies how strictly MD5 hashes should be validated when downloading. Only available when downloading. Available options: NoCheck, LogOnly, FailIfDifferent, FailIfDifferentOrMissing. (default 'FailIfDifferent').
        /// </summary>
        [CLIArgumentName("check-md5", true)]
        public string CheckMD5 { get; set; }

        /// <summary>
        /// Follow symbolic links when uploading from local file system.
        /// </summary>
        [CLIArgumentName("follow-symlinks", false, isFlag: true)]
        public bool? FollowSymlinks { get; set; }

        /// <summary>
        /// Look into sub-directories recursively when uploading from local file system.
        /// </summary>
        [CLIArgumentName("recursive", false, isFlag: true)]
        public bool? Recursive { get; set; }

        /// <summary>
        /// Include only these files when copying. This option supports wildcard characters (*). Separate files by using a ';'.
        /// </summary>
        [CLIArgumentName("include-pattern", true)]
        public string IncludePattern { get; set; }

        /// <summary>
        /// Overwrite the conflicting files and blobs at the destination if this flag is set to true. (default 'true') Possible values include 'true', 'false', 'prompt', and 'ifSourceNewer'. For destinations that support folders, conflicting folder-level properties will be overwritten this flag is 'true' or if a positive response is provided to the prompt. (default "true")
        /// </summary>
        [CLIArgumentName("overwrite", true)]
        public string Overwrite { get; set; }

        /// <summary>
        /// Caps the transfer rate, in megabits per second. Moment-by-moment throughput might vary slightly from the cap. If this option is set to zero, or it is omitted, the throughput isn't capped.
        /// </summary>
        [CLIArgumentName("cap-mbps")]
        public float? CapMbps { get; set; }

        [CLIArgumentName("list-of-files", true)]
        public string ListOfFiles { get; set; }
    }
}
