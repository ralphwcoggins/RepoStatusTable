using RepoStatusTable.Options.SpectreConsole;
using RepoStatusTable.View.SpectreConsoleFigletHeadlineView;

namespace RepoStatusTable.View;

internal class SpectreFigletFactory : ISpectreFigletFactory
{
	private readonly SpectreFigletOptions _options;

	public SpectreFigletFactory( IOptions<SpectreFigletOptions> options )
	{
		_options = options.Value;
	}

	public FigletText CreateFromOptions( string text )
	{
		return new FigletText( text )
			.Alignment( _options.Alignment )
			.Color( _options.Color.GetSpectreConsoleColor() );
	}
}