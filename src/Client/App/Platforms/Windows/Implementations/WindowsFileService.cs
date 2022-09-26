﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Functionland.FxFiles.Client.Shared.Enums;
using Functionland.FxFiles.Client.Shared.Models;

namespace Functionland.FxFiles.Client.App.Platforms.Windows.Implementations;

public partial class WindowsFileService : LocalDeviceFileService
{
    public override Task CopyArtifactsAsync(FsArtifact[] artifacts, string destination, bool overwrite = false, CancellationToken? cancellationToken = null)
    {
        return base.CopyArtifactsAsync(artifacts, destination, overwrite, cancellationToken);
    }

    public override Task<FsArtifact> CreateFileAsync(string path, Stream stream, CancellationToken? cancellationToken = null)
    {
        return base.CreateFileAsync(path, stream, cancellationToken);
    }

    public override Task<List<FsArtifact>> CreateFilesAsync(IEnumerable<(string path, Stream stream)> files, CancellationToken? cancellationToken = null)
    {
        return base.CreateFilesAsync(files, cancellationToken);
    }

    public override Task<FsArtifact> CreateFolderAsync(string path, string folderName, CancellationToken? cancellationToken = null)
    {
        return base.CreateFolderAsync(path, folderName, cancellationToken);
    }

    public override Task DeleteArtifactsAsync(FsArtifact[] artifacts, CancellationToken? cancellationToken = null)
    {
        return base.DeleteArtifactsAsync(artifacts, cancellationToken);
    }

    public override IAsyncEnumerable<FsArtifact> GetArtifactsAsync(string? path = null, string? searchText = null, CancellationToken? cancellationToken = null)
    {
        return base.GetArtifactsAsync(path, searchText, cancellationToken);
    }

    public override Task<FsArtifact?> GetFsArtifactAsync(string? path = null, CancellationToken? cancellationToken = null)
    {
        return base.GetFsArtifactAsync(path, cancellationToken);
    }

    public override Task RenameFolderAsync(string folderPath, string newName, CancellationToken? cancellationToken = null)
    {
        return base.RenameFolderAsync(folderPath, newName, cancellationToken);
    }

    public override Task<Stream> GetFileContentAsync(string filePath, CancellationToken? cancellationToken = null)
    {
        return base.GetFileContentAsync(filePath, cancellationToken);
    }

    public override Task MoveArtifactsAsync(FsArtifact[] artifacts, string destination, bool overwrite = false, CancellationToken? cancellationToken = null)
    {
        return base.MoveArtifactsAsync(artifacts, destination, overwrite, cancellationToken);
    }

    public override Task RenameFileAsync(string filePath, string newName, CancellationToken? cancellationToken = null)
    {
        return base.RenameFileAsync(filePath, newName, cancellationToken);
    }

    public override async Task<FsFileProviderType> GetFsFileProviderTypeAsync(string filePath)
    {
        return FsFileProviderType.InternalMemory;
    }

    public override async Task<List<FsArtifactChanges>> CheckPathExistsAsync(List<string?> paths, CancellationToken? cancellationToken = null)
    {
        return await base.CheckPathExistsAsync(paths, cancellationToken);
    }
}