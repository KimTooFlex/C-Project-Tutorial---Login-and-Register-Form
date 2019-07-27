
function Update-Micron($question) {
  $project = Get-Project
  $projectFile = $project.FullName
  $genPath=Join-Path $PSScriptRoot MicronModelGenerator.exe 
  &"$genPath" "$projectFile" $question    

}

Register-TabExpansion 'Update-Micron' @{
    'question' = {
        "model-first",
        "database-first" 
    }
}

Export-ModuleMember Update-Micron