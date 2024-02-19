using BlazorInputFile;

namespace FormValidationBlazor.Service
{
    public interface IFileUpload
    {
        Task upload(IFileListEntry file);
    }
}
