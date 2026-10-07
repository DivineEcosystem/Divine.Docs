# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team"></a> Class CMsgDOTADPCSearchResults.Types.Team

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCSearchResults.Types.Team : IMessage<CMsgDOTADPCSearchResults.Types.Team>, IEquatable<CMsgDOTADPCSearchResults.Types.Team>, IDeepCloneable<CMsgDOTADPCSearchResults.Types.Team>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCSearchResults.Types.Team](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Team.md)

#### Implements

IMessage<CMsgDOTADPCSearchResults.Types.Team\>, 
[IEquatable<CMsgDOTADPCSearchResults.Types.Team\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCSearchResults.Types.Team\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCSearchResults.Types.Team\>\(CMsgDOTADPCSearchResults.Types.Team, params CMsgDOTADPCSearchResults.Types.Team\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team__ctor"></a> Team\(\)

```csharp
public Team()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_"></a> Team\(Team\)

```csharp
public Team(CMsgDOTADPCSearchResults.Types.Team other)
```

#### Parameters

`other` [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Team.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCSearchResults.Types.Team> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Team.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCSearchResults.Types.Team Clone()
```

#### Returns

 [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_"></a> Equals\(Team\)

```csharp
public bool Equals(CMsgDOTADPCSearchResults.Types.Team other)
```

#### Parameters

`other` [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Team.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_"></a> MergeFrom\(Team\)

```csharp
public void MergeFrom(CMsgDOTADPCSearchResults.Types.Team other)
```

#### Parameters

`other` [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Types_Team_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

