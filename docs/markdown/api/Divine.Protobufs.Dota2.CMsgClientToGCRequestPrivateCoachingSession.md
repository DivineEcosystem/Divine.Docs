# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession"></a> Class CMsgClientToGCRequestPrivateCoachingSession

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPrivateCoachingSession : IMessage<CMsgClientToGCRequestPrivateCoachingSession>, IEquatable<CMsgClientToGCRequestPrivateCoachingSession>, IDeepCloneable<CMsgClientToGCRequestPrivateCoachingSession>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSession.md)

#### Implements

IMessage<CMsgClientToGCRequestPrivateCoachingSession\>, 
[IEquatable<CMsgClientToGCRequestPrivateCoachingSession\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPrivateCoachingSession\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPrivateCoachingSession\>\(CMsgClientToGCRequestPrivateCoachingSession, params CMsgClientToGCRequestPrivateCoachingSession\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession__ctor"></a> CMsgClientToGCRequestPrivateCoachingSession\(\)

```csharp
public CMsgClientToGCRequestPrivateCoachingSession()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_"></a> CMsgClientToGCRequestPrivateCoachingSession\(CMsgClientToGCRequestPrivateCoachingSession\)

```csharp
public CMsgClientToGCRequestPrivateCoachingSession(CMsgClientToGCRequestPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCRequestPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSession.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_Language"></a> Language

```csharp
public uint Language { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPrivateCoachingSession> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSession.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPrivateCoachingSession Clone()
```

#### Returns

 [CMsgClientToGCRequestPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_"></a> Equals\(CMsgClientToGCRequestPrivateCoachingSession\)

```csharp
public bool Equals(CMsgClientToGCRequestPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCRequestPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSession.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_"></a> MergeFrom\(CMsgClientToGCRequestPrivateCoachingSession\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCRequestPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSession_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

