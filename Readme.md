# RevitAddIn.Nice

Test project with `AppLoader` and `Nice3Point` revit template.

### Issues

Issue with the `ImplicitRevitUsings` in the `Nice3Point` target with the revision `AssemblyName` name approach.

Force to add the using in the csproj.
```xml
<ItemGroup>
	<Using Include="Autodesk.Revit.DB" />
	<Using Include="JetBrains.Annotations" />
	<Using Include="Nice3point.Revit.Toolkit" />
	<Using Include="Nice3point.Revit.Extensions" />
	<Using Include="CommunityToolkit.Mvvm.ComponentModel" />
	<Using Include="CommunityToolkit.Mvvm.Input" />
</ItemGroup>
```
Or create a file `GlobalUsing.cs` file.
```csharp
global using Autodesk.Revit.DB;
global using JetBrains.Annotations;
global using Nice3point.Revit.Toolkit;
global using Nice3point.Revit.Extensions;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
```

### Changes

- The `PublishAddinFiles` was disabled.
- The `DisableImplicitRevitUsings` to `true` to disable the insplicit target for Revit.
- The `References` below was added in the `Core` project.
- The `Application` was updated with the panel creation and `Remove` of the panel using the `ricaun.Revit.UI`.
- Update `Projects` with `Revision` to update the `AssemblyName` to generate a diferent `dll` name for each build in `Debug`.

### References
```xml
<PackageReference Include="Nice3point.Revit.Api.AdWindows" Version="$(RevitVersion).*" />
<PackageReference Include="Nice3point.Revit.Api.UIFramework" Version="$(RevitVersion).*" />
<PackageReference Include="ricaun.Revit.UI" Version="*" />
```

---