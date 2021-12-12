using System.Diagnostics.CodeAnalysis;

namespace RepoStatusTable.Options.CellProvider;

[SuppressMessage( "ReSharper", "UnusedAutoPropertyAccessor.Global" )]
[SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
public class GitBranchProviderOptions : ICellProviderOptions
{
	/// <inheritdoc />
	public bool Enable { get; set; } = true;

	/// <inheritdoc />
	public int? Position { get; set; }

	/// <inheritdoc />
	public string Heading { get; set; } = "Branch";
}