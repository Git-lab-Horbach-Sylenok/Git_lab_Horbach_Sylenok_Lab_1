pipeline {
    agent any

    environment {
        DOTNET_CLI_HOME = "${WORKSPACE}\\.dotnet"
        NUGET_PACKAGES = "${WORKSPACE}\\.nuget"
        DOTNET_CLI_TELEMETRY_OPTOUT = '1'
        DOTNET_SKIP_FIRST_TIME_EXPERIENCE = '1'
    }

    stages {
        stage('Restore') {
            steps {
                dir('Lab1_Calculator/Lab_1_Calculator') {
                    bat 'dotnet restore'
                }
            }
        }
        stage('Build') {
            steps {
                dir('Lab1_Calculator/Lab_1_Calculator') {
                    bat 'dotnet build --no-restore -c Release'
                }
            }
        }
        stage('Lint') {
            steps {
                dir('Lab1_Calculator/Lab_1_Calculator') {
                    bat 'dotnet format Lab_1_Calculator.sln --verify-no-changes --no-restore'
                }
            }
        }
        stage('Test') {
            steps {
                dir('Lab1_Calculator/Lab_1_Calculator') {
                    bat 'dotnet test --no-build -c Release'
                }
            }
        }
    }
}