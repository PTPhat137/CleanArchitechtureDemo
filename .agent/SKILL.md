---
id: commit-helper
displayName: "Commit Helper"
description: "Helper skill for crafting clear, convention-based git commit messages and suggesting git commands."
applyTo:
  - "**/*"
---

## 🧠 Skill: Commit Helper

When the user asks for help writing a git commit message, follow these steps:

1. Ask what kind of change this is (e.g., feat, fix, docs, style, refactor, perf, test, chore).
2. Ask for the scope (optional) and a short summary (imperative mood, present tense).
3. Ask for any additional details that should go in the commit body (motivation, background, how it was fixed).
4. Generate a formatted commit message that follows Conventional Commits:

   - `<type>(<scope>): <summary>`
   - Blank line
   - Body (if provided)

5. Provide the exact git commands the user can run, including staging and committing.

### Example Response
```
# Suggested commit message
feat(auth): add OTP login flow

Add support for one-time passwords (OTP) during login to improve security.

# Suggested commands
git add .
git commit -m "feat(auth): add OTP login flow"
```

> ⚠️ Note: This skill does not execute git commands automatically. It only suggests messages and commands for the user to run.
