# <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData"></a> Class CMsgGCAssertJobData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCAssertJobData : IMessage<CMsgGCAssertJobData>, IEquatable<CMsgGCAssertJobData>, IDeepCloneable<CMsgGCAssertJobData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCAssertJobData](Divine.Protobufs.Dota2.CMsgGCAssertJobData.md)

#### Implements

IMessage<CMsgGCAssertJobData\>, 
[IEquatable<CMsgGCAssertJobData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCAssertJobData\>, 
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
[EnumerableExtensions.In<CMsgGCAssertJobData\>\(CMsgGCAssertJobData, params CMsgGCAssertJobData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData__ctor"></a> CMsgGCAssertJobData\(\)

```csharp
public CMsgGCAssertJobData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData__ctor_Divine_Protobufs_Dota2_CMsgGCAssertJobData_"></a> CMsgGCAssertJobData\(CMsgGCAssertJobData\)

```csharp
public CMsgGCAssertJobData(CMsgGCAssertJobData other)
```

#### Parameters

`other` [CMsgGCAssertJobData](Divine.Protobufs.Dota2.CMsgGCAssertJobData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_MessageDataFieldNumber"></a> MessageDataFieldNumber

```csharp
public const int MessageDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_MessageTypeFieldNumber"></a> MessageTypeFieldNumber

```csharp
public const int MessageTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_HasMessageData"></a> HasMessageData

```csharp
public bool HasMessageData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_HasMessageType"></a> HasMessageType

```csharp
public bool HasMessageType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_MessageData"></a> MessageData

```csharp
public ByteString MessageData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_MessageType"></a> MessageType

```csharp
public string MessageType { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCAssertJobData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCAssertJobData](Divine.Protobufs.Dota2.CMsgGCAssertJobData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_ClearMessageData"></a> ClearMessageData\(\)

```csharp
public void ClearMessageData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_ClearMessageType"></a> ClearMessageType\(\)

```csharp
public void ClearMessageType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_Clone"></a> Clone\(\)

```csharp
public CMsgGCAssertJobData Clone()
```

#### Returns

 [CMsgGCAssertJobData](Divine.Protobufs.Dota2.CMsgGCAssertJobData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_Equals_Divine_Protobufs_Dota2_CMsgGCAssertJobData_"></a> Equals\(CMsgGCAssertJobData\)

```csharp
public bool Equals(CMsgGCAssertJobData other)
```

#### Parameters

`other` [CMsgGCAssertJobData](Divine.Protobufs.Dota2.CMsgGCAssertJobData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_MergeFrom_Divine_Protobufs_Dota2_CMsgGCAssertJobData_"></a> MergeFrom\(CMsgGCAssertJobData\)

```csharp
public void MergeFrom(CMsgGCAssertJobData other)
```

#### Parameters

`other` [CMsgGCAssertJobData](Divine.Protobufs.Dota2.CMsgGCAssertJobData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCAssertJobData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

