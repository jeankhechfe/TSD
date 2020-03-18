function Sorting_performance()
{
    $numbersList = New-Object int[] 10000

    for($i=0; $i -lt 10000; $i++)
    {
        $numbersList[$i] = Get-Random -Maximum 100000
    }

    $sort_object = Measure-Command {$sorted = $numbersList | sort-object}
    $sort = Measure-Command {$sorted = $numbersList | sort}

    if($sort_object - $sort -lt 0) {
        echo "Sort-Object is faster by: "  
        echo ($sort - $sort_object)
    }
    if($sort_object - $sort -gt 0) {
        echo "Sort is faster by: "
        echo ($sort_object - $sort)
    }
    if($sort_object - $sort -eq 0) {
        echo "Ooh!! they are equal"
    }
    
}