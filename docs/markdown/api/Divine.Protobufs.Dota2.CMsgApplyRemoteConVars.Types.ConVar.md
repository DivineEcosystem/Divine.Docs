# <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar"></a> Class CMsgApplyRemoteConVars.Types.ConVar

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgApplyRemoteConVars.Types.ConVar : IMessage<CMsgApplyRemoteConVars.Types.ConVar>, IEquatable<CMsgApplyRemoteConVars.Types.ConVar>, IDeepCloneable<CMsgApplyRemoteConVars.Types.ConVar>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgApplyRemoteConVars.Types.ConVar](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.ConVar.md)

#### Implements

IMessage<CMsgApplyRemoteConVars.Types.ConVar\>, 
[IEquatable<CMsgApplyRemoteConVars.Types.ConVar\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgApplyRemoteConVars.Types.ConVar\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgApplyRemoteConVars.Types.ConVar\>\(CMsgApplyRemoteConVars.Types.ConVar, params CMsgApplyRemoteConVars.Types.ConVar\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar__ctor"></a> ConVar\(\)

```csharp
public ConVar()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar__ctor_Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_"></a> ConVar\(ConVar\)

```csharp
public ConVar(CMsgApplyRemoteConVars.Types.ConVar other)
```

#### Parameters

`other` [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md).[Types](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.md).[ConVar](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.ConVar.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_PlatformFieldNumber"></a> PlatformFieldNumber

```csharp
public const int PlatformFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_VersionMaxFieldNumber"></a> VersionMaxFieldNumber

```csharp
public const int VersionMaxFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_VersionMinFieldNumber"></a> VersionMinFieldNumber

```csharp
public const int VersionMinFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_HasPlatform"></a> HasPlatform

```csharp
public bool HasPlatform { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_HasVersionMax"></a> HasVersionMax

```csharp
public bool HasVersionMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_HasVersionMin"></a> HasVersionMin

```csharp
public bool HasVersionMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Parser"></a> Parser

```csharp
public static MessageParser<CMsgApplyRemoteConVars.Types.ConVar> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md).[Types](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.md).[ConVar](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.ConVar.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Platform"></a> Platform

```csharp
public EGCPlatform Platform { get; set; }
```

#### Property Value

 [EGCPlatform](Divine.Protobufs.Steam.EGCPlatform.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_VersionMax"></a> VersionMax

```csharp
public uint VersionMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_VersionMin"></a> VersionMin

```csharp
public uint VersionMin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_ClearPlatform"></a> ClearPlatform\(\)

```csharp
public void ClearPlatform()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_ClearVersionMax"></a> ClearVersionMax\(\)

```csharp
public void ClearVersionMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_ClearVersionMin"></a> ClearVersionMin\(\)

```csharp
public void ClearVersionMin()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Clone"></a> Clone\(\)

```csharp
public CMsgApplyRemoteConVars.Types.ConVar Clone()
```

#### Returns

 [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md).[Types](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.md).[ConVar](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.ConVar.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_Equals_Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_"></a> Equals\(ConVar\)

```csharp
public bool Equals(CMsgApplyRemoteConVars.Types.ConVar other)
```

#### Parameters

`other` [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md).[Types](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.md).[ConVar](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.ConVar.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_MergeFrom_Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_"></a> MergeFrom\(ConVar\)

```csharp
public void MergeFrom(CMsgApplyRemoteConVars.Types.ConVar other)
```

#### Parameters

`other` [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md).[Types](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.md).[ConVar](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.ConVar.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Types_ConVar_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

