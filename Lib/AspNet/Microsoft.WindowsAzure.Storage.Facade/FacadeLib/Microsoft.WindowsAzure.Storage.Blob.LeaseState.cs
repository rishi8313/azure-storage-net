
namespace Microsoft.WindowsAzure.Storage.Blob
{
public enum LeaseState
{
    Unspecified,
    Available,
    Leased,
    Expired,
    Breaking,
    Broken,
}

}