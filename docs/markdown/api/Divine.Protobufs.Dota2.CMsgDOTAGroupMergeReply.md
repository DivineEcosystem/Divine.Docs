# <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply"></a> Class CMsgDOTAGroupMergeReply

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGroupMergeReply : IMessage<CMsgDOTAGroupMergeReply>, IEquatable<CMsgDOTAGroupMergeReply>, IDeepCloneable<CMsgDOTAGroupMergeReply>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGroupMergeReply](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeReply.md)

#### Implements

IMessage<CMsgDOTAGroupMergeReply\>, 
[IEquatable<CMsgDOTAGroupMergeReply\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGroupMergeReply\>, 
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
[EnumerableExtensions.In<CMsgDOTAGroupMergeReply\>\(CMsgDOTAGroupMergeReply, params CMsgDOTAGroupMergeReply\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply__ctor"></a> CMsgDOTAGroupMergeReply\(\)

```csharp
public CMsgDOTAGroupMergeReply()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply__ctor_Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_"></a> CMsgDOTAGroupMergeReply\(CMsgDOTAGroupMergeReply\)

```csharp
public CMsgDOTAGroupMergeReply(CMsgDOTAGroupMergeReply other)
```

#### Parameters

`other` [CMsgDOTAGroupMergeReply](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeReply.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGroupMergeReply> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGroupMergeReply](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeReply.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_Result"></a> Result

```csharp
public EDOTAGroupMergeResult Result { get; set; }
```

#### Property Value

 [EDOTAGroupMergeResult](Divine.Protobufs.Dota2.EDOTAGroupMergeResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGroupMergeReply Clone()
```

#### Returns

 [CMsgDOTAGroupMergeReply](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeReply.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_Equals_Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_"></a> Equals\(CMsgDOTAGroupMergeReply\)

```csharp
public bool Equals(CMsgDOTAGroupMergeReply other)
```

#### Parameters

`other` [CMsgDOTAGroupMergeReply](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeReply.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_"></a> MergeFrom\(CMsgDOTAGroupMergeReply\)

```csharp
public void MergeFrom(CMsgDOTAGroupMergeReply other)
```

#### Parameters

`other` [CMsgDOTAGroupMergeReply](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeReply.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeReply_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

