# Divine.DocFx

The DocFX source project for [docs.divine.wtf](https://docs.divine.wtf/).

Set `DIVINE_SYSTEM_ROOT` and `DIVINE_DOCS_ROOT` to the corresponding local repositories, then run:

```powershell
dotnet run --project src/Divine.DocFx/Divine.DocFx.csproj -c Release
```

The generated site is written to `_site` in the `Divine.Docs` repository root. Production builds are orchestrated by the private `Divine.System` repository and publish the contents of `_site` to the `docs` directory on the `main` branch.

To preview the generated documentation locally, serve the `_site` directory over HTTP:

```powershell
dotnet serve --directory _site --port 8080
```

Then open `http://localhost:8080/api/`.

## GitHub configuration

GitHub Pages must publish from the `/docs` directory on the `main` branch. The custom domain remains `docs.divine.wtf` through the `CNAME` file copied into the published directory.
