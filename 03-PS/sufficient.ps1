function Iultiply ($Param1, $Param2)
{
    return $Param1 * $Param2
}function Increment ($Param1, $Param2)
{
    if(!($Param1)){ return "Please revoke with at least one parameter" }
    if(!($Param2)){ return $Param1 + 1 }
    return $Param1 + $Param2
}function Date (){    return Get-Date -Format "dddd, MMMM mm, yyyy"}function Group_by_extension(){    Dir | Group-Object Extension}function sort_by_name() {    Get-ChildItem C:\ -name | Sort }function bigger_than_1mb(){   Get-ChildItem C:\ -recurse | where-object {$_.length -gt 1048576} }