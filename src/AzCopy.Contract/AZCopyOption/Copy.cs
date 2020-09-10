﻿
// <auto-generated />
namespace AzCopy.Contract
{
    public class CopyOption : CommandArgsBase
    {
        /// <summary>
		/// Activates Windows' SeBackupPrivilege for uploads, or SeRestorePrivilege for downloads, to allow AzCopy to see read all files, regardless of their file system permissions, and to restore all permissions. Requires that the account running AzCopy already has these permissions (e.g. has Administrator rights or is a member of the 'Backup Operators' group). All this flag does is activate privileges that the account already has
        /// </summary>
		[CLIArgumentName("backup")]
		public bool? Backup { get; set; }

        /// <summary>
		/// Defines the type of blob at the destination. This is used for uploading blobs and when copying between accounts (default 'Detect'). Valid values include 'Detect', 'BlockBlob', 'PageBlob', and 'AppendBlob'. When copying between accounts, a value of 'Detect' causes AzCopy to use the type of source blob to determine the type of the destination blob. When uploading a file, 'Detect' determines if the file is a VHD or a VHDX file based on the file extension. If the file is ether a VHD or VHDX file, AzCopy treats the file as a page blob. (default "Detect")
        /// </summary>
		[CLIArgumentName("blob-type", true)]
		public string BlobType { get; set; }

        /// <summary>
		/// upload block blob to Azure Storage using this blob tier. (default "None")
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
		/// Check the length of a file on the destination after the transfer. If there is a mismatch between source and destination, the transfer is marked as failed. (default true)
        /// </summary>
		[CLIArgumentName("check-length")]
		public bool? CheckLength { get; set; }

        /// <summary>
		/// Specifies how strictly MD5 hashes should be validated when downloading. Only available when downloading. Available options: NoCheck, LogOnly, FailIfDifferent, FailIfDifferentOrMissing. (default 'FailIfDifferent') (default "FailIfDifferent")
        /// </summary>
		[CLIArgumentName("check-md5", true)]
		public string CheckMd5 { get; set; }

        /// <summary>
		/// Set the content-disposition header. Returned on download.
        /// </summary>
		[CLIArgumentName("content-disposition", true)]
		public string ContentDisposition { get; set; }

        /// <summary>
		/// Set the content-encoding header. Returned on download.
        /// </summary>
		[CLIArgumentName("content-encoding", true)]
		public string ContentEncoding { get; set; }

        /// <summary>
		/// Set the content-language header. Returned on download.
        /// </summary>
		[CLIArgumentName("content-language", true)]
		public string ContentLanguage { get; set; }

        /// <summary>
		/// Specifies the content type of the file. Implies no-guess-mime-type. Returned on download.
        /// </summary>
		[CLIArgumentName("content-type", true)]
		public string ContentType { get; set; }

        /// <summary>
		/// Automatically decompress files when downloading, if their content-encoding indicates that they are compressed. The supported content-encoding values are 'gzip' and 'deflate'. File extensions of '.gz'/'.gzip' or '.zz' aren't necessary, but will be removed if present.
        /// </summary>
		[CLIArgumentName("decompress")]
		public bool? Decompress { get; set; }

        /// <summary>
		/// (Windows only) Exclude files whose attributes match the attribute list. For example: A;S;R
        /// </summary>
		[CLIArgumentName("exclude-attributes", true)]
		public string ExcludeAttributes { get; set; }

        /// <summary>
		/// Optionally specifies the type of blob (BlockBlob/ PageBlob/ AppendBlob) to exclude when copying blobs from the container or the account. Use of this flag is not applicable for copying data from non azure-service to service. More than one blob should be separated by ';'. 
        /// </summary>
		[CLIArgumentName("exclude-blob-type", true)]
		public string ExcludeBlobType { get; set; }

        /// <summary>
		/// Exclude these paths when copying. This option does not support wildcard characters (*). Checks relative path prefix(For example: myFolder;myFolder/subDirName/file.pdf). When used in combination with account traversal, paths do not include the container name.
        /// </summary>
		[CLIArgumentName("exclude-path", true)]
		public string ExcludePath { get; set; }

        /// <summary>
		/// Exclude these files when copying. This option supports wildcard characters (*)
        /// </summary>
		[CLIArgumentName("exclude-pattern", true)]
		public string ExcludePattern { get; set; }

        /// <summary>
		/// Follow symbolic links when uploading from local file system.
        /// </summary>
		[CLIArgumentName("follow-symlinks")]
		public bool? FollowSymlinks { get; set; }

        /// <summary>
		/// When overwriting an existing file on Windows or Azure Files, force the overwrite to work even if the existing file has its read-only attribute set
        /// </summary>
		[CLIArgumentName("force-if-read-only")]
		public bool? ForceIfReadOnly { get; set; }

        /// <summary>
		/// Optionally specifies the source destination combination. For Example: LocalBlob, BlobLocal, LocalBlobFS.
        /// </summary>
		[CLIArgumentName("from-to", true)]
		public string FromTo { get; set; }

        /// <summary>
		/// (Windows only) Include files whose attributes match the attribute list. For example: A;S;R
        /// </summary>
		[CLIArgumentName("include-attributes", true)]
		public string IncludeAttributes { get; set; }

        /// <summary>
		/// Include only these paths when copying. This option does not support wildcard characters (*). Checks relative path prefix (For example: myFolder;myFolder/subDirName/file.pdf).
        /// </summary>
		[CLIArgumentName("include-path", true)]
		public string IncludePath { get; set; }

        /// <summary>
		/// Include only these files when copying. This option supports wildcard characters (*). Separate files by using a ';'.
        /// </summary>
		[CLIArgumentName("include-pattern", true)]
		public string IncludePattern { get; set; }

        /// <summary>
		/// Define the log verbosity for the log file, available levels: INFO(all requests/responses), WARNING(slow responses), ERROR(only failed requests), and NONE(no output logs). (default 'INFO'). (default "INFO")
        /// </summary>
		[CLIArgumentName("log-level", true)]
		public string LogLevel { get; set; }

        /// <summary>
		/// Upload to Azure Storage with these key-value pairs as metadata.
        /// </summary>
		[CLIArgumentName("metadata", true)]
		public string Metadata { get; set; }

        /// <summary>
		/// Prevents AzCopy from detecting the content-type based on the extension or content of the file.
        /// </summary>
		[CLIArgumentName("no-guess-mime-type")]
		public bool? NoGuessMimeType { get; set; }

        /// <summary>
		/// Overwrite the conflicting files and blobs at the destination if this flag is set to true. (default 'true') Possible values include 'true', 'false', 'prompt', and 'ifSourceNewer'. For destinations that support folders, conflicting folder-level properties will be overwritten this flag is 'true' or if a positive response is provided to the prompt. (default "true")
        /// </summary>
		[CLIArgumentName("overwrite", true)]
		public string Overwrite { get; set; }

        /// <summary>
		/// Upload page blob to Azure Storage using this blob tier. (default 'None'). (default "None")
        /// </summary>
		[CLIArgumentName("page-blob-tier", true)]
		public string PageBlobTier { get; set; }

        /// <summary>
		/// Only available when destination is file system.
        /// </summary>
		[CLIArgumentName("preserve-last-modified-time")]
		public bool? PreserveLastModifiedTime { get; set; }

        /// <summary>
		/// Only has an effect in downloads, and only when --preserve-smb-permissions is used. If true (the default), the file Owner and Group are preserved in downloads. If set to false, --preserve-smb-permissions will still preserve ACLs but Owner and Group will be based on the user running AzCopy (default true)
        /// </summary>
		[CLIArgumentName("preserve-owner")]
		public bool? PreserveOwner { get; set; }

        /// <summary>
		/// False by default. Preserves SMB property info (last write time, creation time, attribute bits) between SMB-aware resources (Windows and Azure Files). Only the attribute bits supported by Azure Files will be transferred; any others will be ignored. This flag applies to both files and folders, unless a file-only filter is specified (e.g. include-pattern). The info transferred for folders is the same as that for files, except for Last Write Time which is never preserved for folders.
        /// </summary>
		[CLIArgumentName("preserve-smb-info")]
		public bool? PreserveSmbInfo { get; set; }

        /// <summary>
		/// False by default. Preserves SMB ACLs between aware resources (Windows and Azure Files). For downloads, you will also need the --backup flag to restore permissions where the new Owner will not be the user running AzCopy. This flag applies to both files and folders, unless a file-only filter is specified (e.g. include-pattern).
        /// </summary>
		[CLIArgumentName("preserve-smb-permissions")]
		public bool? PreserveSmbPermissions { get; set; }

        /// <summary>
		/// Create an MD5 hash of each file, and save the hash as the Content-MD5 property of the destination blob or file. (By default the hash is NOT created.) Only available when uploading.
        /// </summary>
		[CLIArgumentName("put-md5")]
		public bool? PutMd5 { get; set; }

        /// <summary>
		/// Look into sub-directories recursively when uploading from local file system.
        /// </summary>
		[CLIArgumentName("recursive")]
		public bool? Recursive { get; set; }

        /// <summary>
		/// Detect if the source file/blob changes while it is being read. (This parameter only applies to service to service copies, because the corresponding check is permanently enabled for uploads and downloads.)
        /// </summary>
		[CLIArgumentName("s2s-detect-source-changed")]
		public bool? S2sDetectSourceChanged { get; set; }

        /// <summary>
		/// Specifies how invalid metadata keys are handled. Available options: ExcludeIfInvalid, FailIfInvalid, RenameIfInvalid. (default 'ExcludeIfInvalid'). (default "ExcludeIfInvalid")
        /// </summary>
		[CLIArgumentName("s2s-handle-invalid-metadata", true)]
		public string S2sHandleInvalidMetadata { get; set; }

        /// <summary>
		/// Preserve access tier during service to service copy. Please refer to [Azure Blob storage: hot, cool, and archive access tiers](https://docs.microsoft.com/azure/storage/blobs/storage-blob-storage-tiers) to ensure destination storage account supports setting access tier. In the cases that setting access tier is not supported, please use s2sPreserveAccessTier=false to bypass copying access tier. (default true).  (default true)
        /// </summary>
		[CLIArgumentName("s2s-preserve-access-tier")]
		public bool? S2sPreserveAccessTier { get; set; }

        /// <summary>
		/// Preserve full properties during service to service copy. For AWS S3 and Azure File non-single file source, the list operation doesn't return full properties of objects and files. To preserve full properties, AzCopy needs to send one additional request per object or file. (default true)
        /// </summary>
		[CLIArgumentName("s2s-preserve-properties")]
		public bool? S2sPreserveProperties { get; set; }

        /// <summary>
		/// Create a list of specific files (or directories) to transfer, and then tell AzCopy to transfer only those exact files.
        /// </summary>
		[CLIArgumentName("list-of-files", true)]
		public string ListOfFiles { get; set; }

        /// <summary>
		/// Caps the transfer rate, in megabits per second. Moment-by-moment throughput might vary slightly from the cap. If this option is set to zero, or it is omitted, the throughput isn't capped.
        /// </summary>
		[CLIArgumentName("cap-mbps")]
		public float? CapMbps { get; set; }

        /// <summary>
		/// Format of the command's output. The choices include: text, json. The default value is 'text'. (default "text")
        /// </summary>
		[CLIArgumentName("output-type", true)]
		public string OutputType { get; set; }

        /// <summary>
		/// Specifies additional domain suffixes where Azure Active Directory login tokens may be sent.  The default is '*.core.windows.net;*.core.chinacloudapi.cn;*.core.cloudapi.de;*.core.usgovcloudapi.net'. Any listed here are added to the default. For security, you should only put Microsoft Azure domains here. Separate multiple entries with semi-colons.
        /// </summary>
		[CLIArgumentName("trusted-microsoft-suffixes", true)]
		public string TrustedMicrosoftSuffixes { get; set; }

	}
}