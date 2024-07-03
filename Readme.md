# RevitAddIn.Nice

Test project with `AppLoader` and `Nice3Point` revit template.

### Changes

- The `ImplicitUsings` was disabled.
- The `References` was added in the `Core` project.
- The `Application` was updated with the panel creation and `Remove` of the panel using the `ricaun.Revit.UI`.

### References
```xml
<PackageReference Include="Nice3point.Revit.Api.AdWindows" Version="$(RevitVersion).*" />
<PackageReference Include="Nice3point.Revit.Api.UIFramework" Version="$(RevitVersion).*" />
<PackageReference Include="ricaun.Revit.UI" Version="*" />
```

---