function dupdns {
#import the active directory module
$impad = (get-module activedirectory)

if ($impad = $false) {import-module activedirectory}

#define empty array to store computers with duplicate ip address
$duplicate_comp = @()

$comp = get-adcomputer -filter * -properties ipv4address | sort-object -Property ipv4address
$sorted_ipv4 = $comp | foreach {$_.ipv4address} | sort-object
$unique_ipv4 = $comp | foreach {$_.ipv4address} | sort-object | get-unique

#now compared the unique with the sorted
$duplicate_ipv4 = Compare-object -ReferenceObject $unique_ipv4 -DifferenceObject $sorted_ipv4 | foreach {$_.inputobject}

#for each instance in duplicate_ipv4 and for each comp if they have the same IPv4 address place it into the array
foreach ($duplicate_inst in $duplicate_ipv4)
{ foreach ($comp_inst in $comp)
    { if (!($duplicate_inst.compareto($comp_inst.ipv4address)))
        { $duplicate_comp = $duplicate_comp + $comp_inst
        }
    }
}
# pipe all of this into format of your choice
$duplicate_comp | select-object name, ipv4address | export-csv c:\test\dupdns_11-4-19.csv
}