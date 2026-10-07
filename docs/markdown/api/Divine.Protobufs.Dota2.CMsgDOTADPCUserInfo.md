# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo"></a> Class CMsgDOTADPCUserInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCUserInfo : IMessage<CMsgDOTADPCUserInfo>, IEquatable<CMsgDOTADPCUserInfo>, IDeepCloneable<CMsgDOTADPCUserInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCUserInfo](Divine.Protobufs.Dota2.CMsgDOTADPCUserInfo.md)

#### Implements

IMessage<CMsgDOTADPCUserInfo\>, 
[IEquatable<CMsgDOTADPCUserInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCUserInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCUserInfo\>\(CMsgDOTADPCUserInfo, params CMsgDOTADPCUserInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo__ctor"></a> CMsgDOTADPCUserInfo\(\)

```csharp
public CMsgDOTADPCUserInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_"></a> CMsgDOTADPCUserInfo\(CMsgDOTADPCUserInfo\)

```csharp
public CMsgDOTADPCUserInfo(CMsgDOTADPCUserInfo other)
```

#### Parameters

`other` [CMsgDOTADPCUserInfo](Divine.Protobufs.Dota2.CMsgDOTADPCUserInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_IsPlusSubscriberFieldNumber"></a> IsPlusSubscriberFieldNumber

```csharp
public const int IsPlusSubscriberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_HasIsPlusSubscriber"></a> HasIsPlusSubscriber

```csharp
public bool HasIsPlusSubscriber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_IsPlusSubscriber"></a> IsPlusSubscriber

```csharp
public bool IsPlusSubscriber { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCUserInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCUserInfo](Divine.Protobufs.Dota2.CMsgDOTADPCUserInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_ClearIsPlusSubscriber"></a> ClearIsPlusSubscriber\(\)

```csharp
public void ClearIsPlusSubscriber()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCUserInfo Clone()
```

#### Returns

 [CMsgDOTADPCUserInfo](Divine.Protobufs.Dota2.CMsgDOTADPCUserInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_"></a> Equals\(CMsgDOTADPCUserInfo\)

```csharp
public bool Equals(CMsgDOTADPCUserInfo other)
```

#### Parameters

`other` [CMsgDOTADPCUserInfo](Divine.Protobufs.Dota2.CMsgDOTADPCUserInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_"></a> MergeFrom\(CMsgDOTADPCUserInfo\)

```csharp
public void MergeFrom(CMsgDOTADPCUserInfo other)
```

#### Parameters

`other` [CMsgDOTADPCUserInfo](Divine.Protobufs.Dota2.CMsgDOTADPCUserInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCUserInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

