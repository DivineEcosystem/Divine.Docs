# Divine.DocFx

The DocFX source project for [docs.divine.wtf](https://docs.divine.wtf/).

Set `DIVINE_SYSTEM_ROOT`, `DIVINE_DOCS_ROOT`, and `O9K_ROOT` to the corresponding local repositories, then run:

```powershell
dotnet run --project src/Divine.DocFx/Divine.DocFx.csproj -c Release
```

The generated site is written to `_site` in the `Divine.Docs` repository root. Production builds are orchestrated by the private `Divine.System` repository and publish the contents of `_site` to the `gh-pages` branch.

## GitHub configuration

The private `RoccoZero/Divine.System` repository requires these Actions secrets:

- `DIVINE_SOURCE_TOKEN`: read-only access to `DivineEcosystem/Divine` and `DivineEcosystem/Divine.Sdk`.
- `O9K_SOURCE_TOKEN`: read-only access to `DivinePlugins/O9K`.
- `DIVINE_DOCS_TOKEN`: read and write access only to `DivineEcosystem/Divine.Docs`.

The `DivineEcosystem/Divine` and `DivineEcosystem/Divine.Docs` repositories require a `DIVINE_SYSTEM_DISPATCH_TOKEN` Actions secret with permission to send repository dispatch events to `RoccoZero/Divine.System`.

GitHub Pages must publish from the root of the `gh-pages` branch. The custom domain remains `docs.divine.wtf` through the `CNAME` file.
