# <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby"></a> Class CSODOTAStaticLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAStaticLobby : IMessage<CSODOTAStaticLobby>, IEquatable<CSODOTAStaticLobby>, IDeepCloneable<CSODOTAStaticLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAStaticLobby](Divine.Protobufs.Dota2.CSODOTAStaticLobby.md)

#### Implements

IMessage<CSODOTAStaticLobby\>, 
[IEquatable<CSODOTAStaticLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAStaticLobby\>, 
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
[EnumerableExtensions.In<CSODOTAStaticLobby\>\(CSODOTAStaticLobby, params CSODOTAStaticLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby__ctor"></a> CSODOTAStaticLobby\(\)

```csharp
public CSODOTAStaticLobby()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby__ctor_Divine_Protobufs_Dota2_CSODOTAStaticLobby_"></a> CSODOTAStaticLobby\(CSODOTAStaticLobby\)

```csharp
public CSODOTAStaticLobby(CSODOTAStaticLobby other)
```

#### Parameters

`other` [CSODOTAStaticLobby](Divine.Protobufs.Dota2.CSODOTAStaticLobby.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_AllMembersFieldNumber"></a> AllMembersFieldNumber

```csharp
public const int AllMembersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_IsLastMatchInSeriesFieldNumber"></a> IsLastMatchInSeriesFieldNumber

```csharp
public const int IsLastMatchInSeriesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_IsPlayerDraftFieldNumber"></a> IsPlayerDraftFieldNumber

```csharp
public const int IsPlayerDraftFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_AllMembers"></a> AllMembers

```csharp
public RepeatedField<CSODOTAStaticLobbyMember> AllMembers { get; }
```

#### Property Value

 RepeatedField<[CSODOTAStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAStaticLobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_HasIsLastMatchInSeries"></a> HasIsLastMatchInSeries

```csharp
public bool HasIsLastMatchInSeries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_HasIsPlayerDraft"></a> HasIsPlayerDraft

```csharp
public bool HasIsPlayerDraft { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_IsLastMatchInSeries"></a> IsLastMatchInSeries

```csharp
public bool IsLastMatchInSeries { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_IsPlayerDraft"></a> IsPlayerDraft

```csharp
public bool IsPlayerDraft { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAStaticLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAStaticLobby](Divine.Protobufs.Dota2.CSODOTAStaticLobby.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_ClearIsLastMatchInSeries"></a> ClearIsLastMatchInSeries\(\)

```csharp
public void ClearIsLastMatchInSeries()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_ClearIsPlayerDraft"></a> ClearIsPlayerDraft\(\)

```csharp
public void ClearIsPlayerDraft()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_Clone"></a> Clone\(\)

```csharp
public CSODOTAStaticLobby Clone()
```

#### Returns

 [CSODOTAStaticLobby](Divine.Protobufs.Dota2.CSODOTAStaticLobby.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_Equals_Divine_Protobufs_Dota2_CSODOTAStaticLobby_"></a> Equals\(CSODOTAStaticLobby\)

```csharp
public bool Equals(CSODOTAStaticLobby other)
```

#### Parameters

`other` [CSODOTAStaticLobby](Divine.Protobufs.Dota2.CSODOTAStaticLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_MergeFrom_Divine_Protobufs_Dota2_CSODOTAStaticLobby_"></a> MergeFrom\(CSODOTAStaticLobby\)

```csharp
public void MergeFrom(CSODOTAStaticLobby other)
```

#### Parameters

`other` [CSODOTAStaticLobby](Divine.Protobufs.Dota2.CSODOTAStaticLobby.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

