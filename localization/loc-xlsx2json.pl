use Data::Dumper;
use Spreadsheet::ParseXLSX;
use JSON;

my $langs = [];
my $vocabulary = {};
my $parser = Spreadsheet::ParseXLSX->new;

opendir( my $dir, "." );
my @localizationTables = grep { /localization.*?\.xlsx$/i } readdir( $dir );
closedir( $dir );

foreach my $table ( @localizationTables ) {

	my $workbook = $parser->parse( $table );

# parse localization .xlsx
	if ( defined $workbook ) {
		for my $worksheet ( $workbook->worksheets() ) {
			my ( $row_min, $row_max ) = $worksheet->row_range();
			my ( $col_min, $col_max ) = $worksheet->col_range();

			for my $row ( $row_min .. $row_max ) {
				if ( $row == $row_min ) {
					for my $col ( $col_min .. $col_max ) {
						my $cell = $worksheet->get_cell( $row, $col );
						next unless $cell;
						my $value = $cell->value();
						print $col . ": " . $value . "\n";
						if ( $col != $col_min ) {
							push @{$langs}, $value;
#							$langs->[$col - $col_min - 1] = $cell->value();
						}
					}
				} else {
					my $id = "";
					for my $col ( $col_min .. $col_max ) {

						my $cell = $worksheet->get_cell( $row, $col );
						next unless $cell;
			
						my $value = $cell->value();
						if ( $col == $col_min ) {
							$id = $value;
						} else {
							$vocabulary->{$langs->[$col - $col_min - 1]}{$id} = $value;
						}
					}
				}
			}
		}
	}
}

print Dumper( $vocabulary );

foreach my $lang ( keys %{$vocabulary} ) {
	print "Dumping " . $lang . " language\n" ;
	my $fh;
	if ( open( $fh, ">", "localizationStrings-" . $lang . ".json" )) {
		foreach my $id ( keys %{$vocabulary->{$lang}} ) {
			my $localizationEntry = {
				id => $id,
				language => $lang,
				value => $vocabulary->{$lang}{$id}
			};
			print $fh encode_json( $localizationEntry ) . "\n";
		}
		close( $fh );
	}
}
