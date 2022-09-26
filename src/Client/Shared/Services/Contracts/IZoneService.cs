﻿namespace Functionland.FxFiles.Client.Shared.Services.Contracts
{
    public interface IZoneService
    {
        Task<List<FsZone>> GetZonesAsync(string? searchText = null, CancellationToken? cancellationToken = null);
        Task<IAsyncEnumerable<FsArtifact>> GetZoneArtifactsAsync(int zoneId, FsCategoryFilterType[]? categoryFilters = null, FsTimeFilterType? timeFilter = null, CancellationToken? cancellationToken = null);
        Task<FsZone> CreateZoneAsync(string zoneName, CancellationToken? cancellationToken = null);
        Task<FsZone> ShareArtifactsAsync(IEnumerable<FsArtifact>? artifacts = null, string[]? dIds = null, CancellationToken? cancellationToken = null);
        Task AddArtifactToZoneAsync(int zoneId, string filePath, CancellationToken? cancellationToken = null);
        Task MergeZoneAsync(int sourceZoneId, int destinationZoneId, CancellationToken? cancellationToken = null);
        Task RenameZoneAsync(int zoneId, string newName, CancellationToken? cancellationToken = null);
        Task DeleteZoneAsync(int zoneId, CancellationToken? cancellationToken = null);
        Task ShareZoneAsync(string ZoneName, string dId, CancellationToken? cancellationToken = null);// share my zone with others
        Task UnShareArtifactAsync(string filePath, string dId, CancellationToken? cancellationToken = null);
    }
}