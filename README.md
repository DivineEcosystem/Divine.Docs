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

The private `RoccoZero/Divine.System` repository requires these Actions secrets:

- `DIVINE_SOURCE_TOKEN`: read-only access to `DivineEcosystem/Divine` and `DivineEcosystem/Divine.Sdk`.
- `DIVINE_DOCS_TOKEN`: read and write access only to `DivineEcosystem/Divine.Docs`.

No secret that grants access to the private `Divine.System` repository is stored in `Divine` or `Divine.Docs`. The private workflow runs immediately after changes to `Divine.System` and once per hour to detect new revisions of `Divine` and `Divine.Docs`. Unchanged revisions are skipped. The workflow can also be started manually.

GitHub Pages must publish from the `/docs` directory on the `main` branch. The custom domain remains `docs.divine.wtf` through the `CNAME` file copied into the published directory.
