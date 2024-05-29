namespace FFF.MimeTypes;

/// <summary>
/// Provides extension methods for strings to convert them to MIME types or extensions based on file path or MIME type string.
/// </summary>
public static class StringExtension
{
    /// <summary>
    /// Converts the string representing a file path to its corresponding MIME type.
    /// Returns a default MIME type ("application/octet-stream") if no specific MIME type is found.
    /// </summary>
    /// <param name="filePath">The file path as a string.</param>
    /// <returns>The corresponding MIME type if found; otherwise, the default MIME type.</returns>
    public static string? ToMimeType(this string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            return MimeTypeMap.DefaultMimeType; // Or return null if you prefer no result when input is invalid.

        return MimeTypeMap.GetMimeType(filePath);
    }

    /// <summary>
    /// Determines if the string can be resolved to a MIME type.
    /// </summary>
    /// <param name="filePath">The file path as a string.</param>
    /// <returns>True if a MIME type is associated with the file extension; otherwise, false.</returns>
    public static bool IsMimeType(this string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            return false;

        return MimeTypeMap.TryGetMimeType(filePath, out _);
    }

    /// <summary>
    /// Converts the string representing a MIME type to its corresponding file extension.
    /// Throws an exception if the MIME type is not registered.
    /// </summary>
    /// <param name="mimeType">The MIME type as a string.</param>
    /// <returns>The corresponding file extension if the MIME type is registered.</returns>
    public static string? ToExtension(this string mimeType)
    {
        if (string.IsNullOrWhiteSpace(mimeType))
            throw new ArgumentException("Mime type cannot be null or empty.", nameof(mimeType));

        return MimeTypeMap.GetExtension(mimeType);
    }
}

