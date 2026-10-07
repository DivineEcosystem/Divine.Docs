# <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged"></a> Class CDOTAUserMessage\_TeamCaptainChanged

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMessage_TeamCaptainChanged : IMessage<CDOTAUserMessage_TeamCaptainChanged>, IEquatable<CDOTAUserMessage_TeamCaptainChanged>, IDeepCloneable<CDOTAUserMessage_TeamCaptainChanged>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMessage\_TeamCaptainChanged](Divine.Protobufs.Dota2.CDOTAUserMessage\_TeamCaptainChanged.md)

#### Implements

IMessage<CDOTAUserMessage\_TeamCaptainChanged\>, 
[IEquatable<CDOTAUserMessage\_TeamCaptainChanged\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMessage\_TeamCaptainChanged\>, 
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
[EnumerableExtensions.In<CDOTAUserMessage\_TeamCaptainChanged\>\(CDOTAUserMessage\_TeamCaptainChanged, params CDOTAUserMessage\_TeamCaptainChanged\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged__ctor"></a> CDOTAUserMessage\_TeamCaptainChanged\(\)

```csharp
public CDOTAUserMessage_TeamCaptainChanged()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged__ctor_Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_"></a> CDOTAUserMessage\_TeamCaptainChanged\(CDOTAUserMessage\_TeamCaptainChanged\)

```csharp
public CDOTAUserMessage_TeamCaptainChanged(CDOTAUserMessage_TeamCaptainChanged other)
```

#### Parameters

`other` [CDOTAUserMessage\_TeamCaptainChanged](Divine.Protobufs.Dota2.CDOTAUserMessage\_TeamCaptainChanged.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_CaptainPlayerIdFieldNumber"></a> CaptainPlayerIdFieldNumber

```csharp
public const int CaptainPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_CaptainPlayerId"></a> CaptainPlayerId

```csharp
public int CaptainPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_HasCaptainPlayerId"></a> HasCaptainPlayerId

```csharp
public bool HasCaptainPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMessage_TeamCaptainChanged> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMessage\_TeamCaptainChanged](Divine.Protobufs.Dota2.CDOTAUserMessage\_TeamCaptainChanged.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_ClearCaptainPlayerId"></a> ClearCaptainPlayerId\(\)

```csharp
public void ClearCaptainPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMessage_TeamCaptainChanged Clone()
```

#### Returns

 [CDOTAUserMessage\_TeamCaptainChanged](Divine.Protobufs.Dota2.CDOTAUserMessage\_TeamCaptainChanged.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_Equals_Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_"></a> Equals\(CDOTAUserMessage\_TeamCaptainChanged\)

```csharp
public bool Equals(CDOTAUserMessage_TeamCaptainChanged other)
```

#### Parameters

`other` [CDOTAUserMessage\_TeamCaptainChanged](Divine.Protobufs.Dota2.CDOTAUserMessage\_TeamCaptainChanged.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_"></a> MergeFrom\(CDOTAUserMessage\_TeamCaptainChanged\)

```csharp
public void MergeFrom(CDOTAUserMessage_TeamCaptainChanged other)
```

#### Parameters

`other` [CDOTAUserMessage\_TeamCaptainChanged](Divine.Protobufs.Dota2.CDOTAUserMessage\_TeamCaptainChanged.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMessage_TeamCaptainChanged_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

