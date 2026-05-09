---
name: commit-message
description: Generate a concise commit message for staged changes.
commands:
  - /commit
inputs:
  - changes: Description of staged changes or diff summary
outputs:
  - message: A commit message string
examples:
  - input: "Updated README with installation steps"
    output: "docs: add installation steps to README"
  
---  