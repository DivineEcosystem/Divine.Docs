# <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress"></a> Class CMsgLobbyFeaturedGamemodeProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyFeaturedGamemodeProgress : IMessage<CMsgLobbyFeaturedGamemodeProgress>, IEquatable<CMsgLobbyFeaturedGamemodeProgress>, IDeepCloneable<CMsgLobbyFeaturedGamemodeProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md)

#### Implements

IMessage<CMsgLobbyFeaturedGamemodeProgress\>, 
[IEquatable<CMsgLobbyFeaturedGamemodeProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyFeaturedGamemodeProgress\>, 
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
[EnumerableExtensions.In<CMsgLobbyFeaturedGamemodeProgress\>\(CMsgLobbyFeaturedGamemodeProgress, params CMsgLobbyFeaturedGamemodeProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress__ctor"></a> CMsgLobbyFeaturedGamemodeProgress\(\)

```csharp
public CMsgLobbyFeaturedGamemodeProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress__ctor_Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_"></a> CMsgLobbyFeaturedGamemodeProgress\(CMsgLobbyFeaturedGamemodeProgress\)

```csharp
public CMsgLobbyFeaturedGamemodeProgress(CMsgLobbyFeaturedGamemodeProgress other)
```

#### Parameters

`other` [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_AccountsFieldNumber"></a> AccountsFieldNumber

```csharp
public const int AccountsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Accounts"></a> Accounts

```csharp
public RepeatedField<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress> Accounts { get; }
```

#### Property Value

 RepeatedField<[CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.md).[AccountProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyFeaturedGamemodeProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyFeaturedGamemodeProgress Clone()
```

#### Returns

 [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Equals_Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_"></a> Equals\(CMsgLobbyFeaturedGamemodeProgress\)

```csharp
public bool Equals(CMsgLobbyFeaturedGamemodeProgress other)
```

#### Parameters

`other` [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_"></a> MergeFrom\(CMsgLobbyFeaturedGamemodeProgress\)

```csharp
public void MergeFrom(CMsgLobbyFeaturedGamemodeProgress other)
```

#### Parameters

`other` [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

