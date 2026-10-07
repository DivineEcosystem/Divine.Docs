# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam"></a> Class CDOTAClientMsg\_PlayerDraftPreferTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_PlayerDraftPreferTeam : IMessage<CDOTAClientMsg_PlayerDraftPreferTeam>, IEquatable<CDOTAClientMsg_PlayerDraftPreferTeam>, IDeepCloneable<CDOTAClientMsg_PlayerDraftPreferTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_PlayerDraftPreferTeam](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferTeam.md)

#### Implements

IMessage<CDOTAClientMsg\_PlayerDraftPreferTeam\>, 
[IEquatable<CDOTAClientMsg\_PlayerDraftPreferTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_PlayerDraftPreferTeam\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_PlayerDraftPreferTeam\>\(CDOTAClientMsg\_PlayerDraftPreferTeam, params CDOTAClientMsg\_PlayerDraftPreferTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam__ctor"></a> CDOTAClientMsg\_PlayerDraftPreferTeam\(\)

```csharp
public CDOTAClientMsg_PlayerDraftPreferTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_"></a> CDOTAClientMsg\_PlayerDraftPreferTeam\(CDOTAClientMsg\_PlayerDraftPreferTeam\)

```csharp
public CDOTAClientMsg_PlayerDraftPreferTeam(CDOTAClientMsg_PlayerDraftPreferTeam other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftPreferTeam](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_PlayerDraftPreferTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_PlayerDraftPreferTeam](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_Team"></a> Team

```csharp
public int Team { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_PlayerDraftPreferTeam Clone()
```

#### Returns

 [CDOTAClientMsg\_PlayerDraftPreferTeam](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferTeam.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_"></a> Equals\(CDOTAClientMsg\_PlayerDraftPreferTeam\)

```csharp
public bool Equals(CDOTAClientMsg_PlayerDraftPreferTeam other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftPreferTeam](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_"></a> MergeFrom\(CDOTAClientMsg\_PlayerDraftPreferTeam\)

```csharp
public void MergeFrom(CDOTAClientMsg_PlayerDraftPreferTeam other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftPreferTeam](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferTeam.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

