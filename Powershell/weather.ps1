#pull RSS feed of anchorage airport weather.  



function folderthere
	{
	$folder = 'C:\weatherreport'
	
	$foldercheck = (test-path $folder) 
	
	if (!$foldercheck)
		{md $folder}
		
	else {Write-host 'you good'}
	}

function Ryanreport 
	{		
	$pathtoxml = 'C:\weatherreport\connectfeed.xml'
	$websiterss = 'https://w1.weather.gov/xml/current_obs/display.php?stid=PANC'
	
	try {
		$read_rss = Invoke-WebRequest -Uri $websiterss -OutFile $pathtoxml
		}
	
	catch 
		{
		write-host "error with weather report"
		}
	
	try 
		{	
		[xml]$xmldocument = get-content $pathtoxml
		}
	catch
		{
		write-host "error with reading xml"
		}

	$readthis = $xmldocument.current_observation | select-object location,
				station_id,
				observation_time,
				weather, 
				temp_f, 
				temp_c, 
				suggested_pickup, 
				suggested_pickup_period, 
				latitude,
				longitude,
				wind_mph,
				wind_dir,
				wind_string,
				dewpoint_f,
				dewpoint_c,
				visibility_mi | Format-List 

	try {
		$readthis
		}
	catch 
		{
		write-host "can't read $_"
		}
	}

folderthere
Ryanreport
