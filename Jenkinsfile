pipeline {
  agent any
  stages {
    stage('Simple_Build') {
      steps {
        sh 'dotnet restore src/AvaloniaMvvm.sln'
        sh 'dotnet build src/AvaloniaMvvm.sln'
      }
    }

    stage('sonar scan start') {
      steps {
        sh '''cd src
dotnet sonarscanner begin /k:"sonar-analysis-avaloniamvvm-prism" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="0c01f5a1334a866d2487fcf0ad04bce2343b015b"
dotnet build
dotnet sonarscanner end /d:sonar.login="0c01f5a1334a866d2487fcf0ad04bce2343b015b"'''
      }
    }

  }
}