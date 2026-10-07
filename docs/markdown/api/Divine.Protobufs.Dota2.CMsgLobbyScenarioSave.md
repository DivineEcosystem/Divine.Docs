# <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave"></a> Class CMsgLobbyScenarioSave

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyScenarioSave : IMessage<CMsgLobbyScenarioSave>, IEquatable<CMsgLobbyScenarioSave>, IDeepCloneable<CMsgLobbyScenarioSave>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyScenarioSave](Divine.Protobufs.Dota2.CMsgLobbyScenarioSave.md)

#### Implements

IMessage<CMsgLobbyScenarioSave\>, 
[IEquatable<CMsgLobbyScenarioSave\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyScenarioSave\>, 
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
[EnumerableExtensions.In<CMsgLobbyScenarioSave\>\(CMsgLobbyScenarioSave, params CMsgLobbyScenarioSave\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave__ctor"></a> CMsgLobbyScenarioSave\(\)

```csharp
public CMsgLobbyScenarioSave()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave__ctor_Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_"></a> CMsgLobbyScenarioSave\(CMsgLobbyScenarioSave\)

```csharp
public CMsgLobbyScenarioSave(CMsgLobbyScenarioSave other)
```

#### Parameters

`other` [CMsgLobbyScenarioSave](Divine.Protobufs.Dota2.CMsgLobbyScenarioSave.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyScenarioSave> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyScenarioSave](Divine.Protobufs.Dota2.CMsgLobbyScenarioSave.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_Version"></a> Version

```csharp
public int Version { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyScenarioSave Clone()
```

#### Returns

 [CMsgLobbyScenarioSave](Divine.Protobufs.Dota2.CMsgLobbyScenarioSave.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_Equals_Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_"></a> Equals\(CMsgLobbyScenarioSave\)

```csharp
public bool Equals(CMsgLobbyScenarioSave other)
```

#### Parameters

`other` [CMsgLobbyScenarioSave](Divine.Protobufs.Dota2.CMsgLobbyScenarioSave.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_"></a> MergeFrom\(CMsgLobbyScenarioSave\)

```csharp
public void MergeFrom(CMsgLobbyScenarioSave other)
```

#### Parameters

`other` [CMsgLobbyScenarioSave](Divine.Protobufs.Dota2.CMsgLobbyScenarioSave.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyScenarioSave_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

