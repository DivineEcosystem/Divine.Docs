# <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo"></a> Class CMsgGCUpdateSubGCSessionInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCUpdateSubGCSessionInfo : IMessage<CMsgGCUpdateSubGCSessionInfo>, IEquatable<CMsgGCUpdateSubGCSessionInfo>, IDeepCloneable<CMsgGCUpdateSubGCSessionInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md)

#### Implements

IMessage<CMsgGCUpdateSubGCSessionInfo\>, 
[IEquatable<CMsgGCUpdateSubGCSessionInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCUpdateSubGCSessionInfo\>, 
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
[EnumerableExtensions.In<CMsgGCUpdateSubGCSessionInfo\>\(CMsgGCUpdateSubGCSessionInfo, params CMsgGCUpdateSubGCSessionInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo__ctor"></a> CMsgGCUpdateSubGCSessionInfo\(\)

```csharp
public CMsgGCUpdateSubGCSessionInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo__ctor_Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_"></a> CMsgGCUpdateSubGCSessionInfo\(CMsgGCUpdateSubGCSessionInfo\)

```csharp
public CMsgGCUpdateSubGCSessionInfo(CMsgGCUpdateSubGCSessionInfo other)
```

#### Parameters

`other` [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_UpdatesFieldNumber"></a> UpdatesFieldNumber

```csharp
public const int UpdatesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCUpdateSubGCSessionInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Updates"></a> Updates

```csharp
public RepeatedField<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate> Updates { get; }
```

#### Property Value

 RepeatedField<[CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.md).[CMsgUpdate](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCUpdateSubGCSessionInfo Clone()
```

#### Returns

 [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Equals_Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_"></a> Equals\(CMsgGCUpdateSubGCSessionInfo\)

```csharp
public bool Equals(CMsgGCUpdateSubGCSessionInfo other)
```

#### Parameters

`other` [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_"></a> MergeFrom\(CMsgGCUpdateSubGCSessionInfo\)

```csharp
public void MergeFrom(CMsgGCUpdateSubGCSessionInfo other)
```

#### Parameters

`other` [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

