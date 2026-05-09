skills:
  - name: commit message
    description: Generate a concise commit message for staged changes.
    allowed-tools: Read, Grep, Glob, Bash
    commands:
      - /commit
    inputs:
      - changes: Description of staged changes or diff summary
    outputs:
      - message: A commit message string
    examples:
      - input: "Updated README with installation steps"
        output: "docs: add installation steps to README"

  - name: run tests
    description: Execute unit or integration tests for the project.
    allowed-tools: Read, Grep, Glob, Bash
    commands:
      - /test
    inputs:
      - scope: Which tests to run (unit, integration, all)
    outputs:
      - result: Test results summary
    examples:
      - input: "Run unit tests"
        output: "All 42 unit tests passed"

  - name: lint code
    description: Run linting checks to enforce coding standards.
    allowed-tools: Read, Grep, Glob, Bash
    commands:
      - /lint
    inputs:
      - scope: Files or modules to lint
    outputs:
      - report: Linting issues summary
    examples:
      - input: "Lint src folder"
        output: "No linting issues found in src/"

  - name: build project
    description: Compile or package the project for deployment.
    allowed-tools: Read, Grep, Glob, Bash
    commands:
      - /build
    inputs:
      - target: Build target (debug, release)
    outputs:
      - artifact: Build output path or package
    examples:
      - input: "Build release version"
        output: "Release build completed: dist/app-v1.2.0.zip"

  - name: deploy project
    description: Deploy the project to staging or production environment.
    allowed-tools: Read, Grep, Glob, Bash
    commands:
      - /deploy
    inputs:
      - environment: Target environment (staging, production)
    outputs:
      - status: Deployment status message
    examples:
      - input: "Deploy to staging"
        output: "Deployment to staging completed successfully"

  - name: release project
    description: Tag and publish a new version of the project.
    allowed-tools: Read, Grep, Glob, Bash
    commands:
      - /release
    inputs:
      - version: Version number to release
    outputs:
      - status: Release confirmation message
    examples:
      - input: "Release version 1.2.0"
        output: "Version 1.2.0 released and tagged in repository"
