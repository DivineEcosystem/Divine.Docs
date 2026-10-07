# <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat"></a> Class CMsgGCToServerEvaluateToxicChat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerEvaluateToxicChat : IMessage<CMsgGCToServerEvaluateToxicChat>, IEquatable<CMsgGCToServerEvaluateToxicChat>, IDeepCloneable<CMsgGCToServerEvaluateToxicChat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgGCToServerEvaluateToxicChat.md)

#### Implements

IMessage<CMsgGCToServerEvaluateToxicChat\>, 
[IEquatable<CMsgGCToServerEvaluateToxicChat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerEvaluateToxicChat\>, 
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
[EnumerableExtensions.In<CMsgGCToServerEvaluateToxicChat\>\(CMsgGCToServerEvaluateToxicChat, params CMsgGCToServerEvaluateToxicChat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat__ctor"></a> CMsgGCToServerEvaluateToxicChat\(\)

```csharp
public CMsgGCToServerEvaluateToxicChat()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat__ctor_Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_"></a> CMsgGCToServerEvaluateToxicChat\(CMsgGCToServerEvaluateToxicChat\)

```csharp
public CMsgGCToServerEvaluateToxicChat(CMsgGCToServerEvaluateToxicChat other)
```

#### Parameters

`other` [CMsgGCToServerEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgGCToServerEvaluateToxicChat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_ReporterAccountIdFieldNumber"></a> ReporterAccountIdFieldNumber

```csharp
public const int ReporterAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_HasReporterAccountId"></a> HasReporterAccountId

```csharp
public bool HasReporterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerEvaluateToxicChat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgGCToServerEvaluateToxicChat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_ReporterAccountId"></a> ReporterAccountId

```csharp
public uint ReporterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_ClearReporterAccountId"></a> ClearReporterAccountId\(\)

```csharp
public void ClearReporterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerEvaluateToxicChat Clone()
```

#### Returns

 [CMsgGCToServerEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgGCToServerEvaluateToxicChat.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_Equals_Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_"></a> Equals\(CMsgGCToServerEvaluateToxicChat\)

```csharp
public bool Equals(CMsgGCToServerEvaluateToxicChat other)
```

#### Parameters

`other` [CMsgGCToServerEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgGCToServerEvaluateToxicChat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_"></a> MergeFrom\(CMsgGCToServerEvaluateToxicChat\)

```csharp
public void MergeFrom(CMsgGCToServerEvaluateToxicChat other)
```

#### Parameters

`other` [CMsgGCToServerEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgGCToServerEvaluateToxicChat.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerEvaluateToxicChat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

