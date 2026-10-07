# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo"></a> Class CMsgGCToClientRequestMMInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRequestMMInfo : IMessage<CMsgGCToClientRequestMMInfo>, IEquatable<CMsgGCToClientRequestMMInfo>, IDeepCloneable<CMsgGCToClientRequestMMInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRequestMMInfo](Divine.Protobufs.Dota2.CMsgGCToClientRequestMMInfo.md)

#### Implements

IMessage<CMsgGCToClientRequestMMInfo\>, 
[IEquatable<CMsgGCToClientRequestMMInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRequestMMInfo\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRequestMMInfo\>\(CMsgGCToClientRequestMMInfo, params CMsgGCToClientRequestMMInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo__ctor"></a> CMsgGCToClientRequestMMInfo\(\)

```csharp
public CMsgGCToClientRequestMMInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_"></a> CMsgGCToClientRequestMMInfo\(CMsgGCToClientRequestMMInfo\)

```csharp
public CMsgGCToClientRequestMMInfo(CMsgGCToClientRequestMMInfo other)
```

#### Parameters

`other` [CMsgGCToClientRequestMMInfo](Divine.Protobufs.Dota2.CMsgGCToClientRequestMMInfo.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRequestMMInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRequestMMInfo](Divine.Protobufs.Dota2.CMsgGCToClientRequestMMInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRequestMMInfo Clone()
```

#### Returns

 [CMsgGCToClientRequestMMInfo](Divine.Protobufs.Dota2.CMsgGCToClientRequestMMInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_"></a> Equals\(CMsgGCToClientRequestMMInfo\)

```csharp
public bool Equals(CMsgGCToClientRequestMMInfo other)
```

#### Parameters

`other` [CMsgGCToClientRequestMMInfo](Divine.Protobufs.Dota2.CMsgGCToClientRequestMMInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_"></a> MergeFrom\(CMsgGCToClientRequestMMInfo\)

```csharp
public void MergeFrom(CMsgGCToClientRequestMMInfo other)
```

#### Parameters

`other` [CMsgGCToClientRequestMMInfo](Divine.Protobufs.Dota2.CMsgGCToClientRequestMMInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestMMInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

