# macOS Setup (VS Code)

1) Install Homebrew (if needed):
```bash
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
```

2) Install .NET 8 SDK:
```bash
brew install --cask dotnet-sdk
```

3) Install VS Code + Extensions:
- C# Dev Kit
- .NET Install Tool
- IntelliCode

4) Verify:
```bash
dotnet --version
```
