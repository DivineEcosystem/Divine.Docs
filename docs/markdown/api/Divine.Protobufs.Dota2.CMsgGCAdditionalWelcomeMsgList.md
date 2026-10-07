# <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList"></a> Class CMsgGCAdditionalWelcomeMsgList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCAdditionalWelcomeMsgList : IMessage<CMsgGCAdditionalWelcomeMsgList>, IEquatable<CMsgGCAdditionalWelcomeMsgList>, IDeepCloneable<CMsgGCAdditionalWelcomeMsgList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCAdditionalWelcomeMsgList](Divine.Protobufs.Dota2.CMsgGCAdditionalWelcomeMsgList.md)

#### Implements

IMessage<CMsgGCAdditionalWelcomeMsgList\>, 
[IEquatable<CMsgGCAdditionalWelcomeMsgList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCAdditionalWelcomeMsgList\>, 
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
[EnumerableExtensions.In<CMsgGCAdditionalWelcomeMsgList\>\(CMsgGCAdditionalWelcomeMsgList, params CMsgGCAdditionalWelcomeMsgList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList__ctor"></a> CMsgGCAdditionalWelcomeMsgList\(\)

```csharp
public CMsgGCAdditionalWelcomeMsgList()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList__ctor_Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_"></a> CMsgGCAdditionalWelcomeMsgList\(CMsgGCAdditionalWelcomeMsgList\)

```csharp
public CMsgGCAdditionalWelcomeMsgList(CMsgGCAdditionalWelcomeMsgList other)
```

#### Parameters

`other` [CMsgGCAdditionalWelcomeMsgList](Divine.Protobufs.Dota2.CMsgGCAdditionalWelcomeMsgList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_WelcomeMessagesFieldNumber"></a> WelcomeMessagesFieldNumber

```csharp
public const int WelcomeMessagesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCAdditionalWelcomeMsgList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCAdditionalWelcomeMsgList](Divine.Protobufs.Dota2.CMsgGCAdditionalWelcomeMsgList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_WelcomeMessages"></a> WelcomeMessages

```csharp
public RepeatedField<CExtraMsgBlock> WelcomeMessages { get; }
```

#### Property Value

 RepeatedField<[CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_Clone"></a> Clone\(\)

```csharp
public CMsgGCAdditionalWelcomeMsgList Clone()
```

#### Returns

 [CMsgGCAdditionalWelcomeMsgList](Divine.Protobufs.Dota2.CMsgGCAdditionalWelcomeMsgList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_Equals_Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_"></a> Equals\(CMsgGCAdditionalWelcomeMsgList\)

```csharp
public bool Equals(CMsgGCAdditionalWelcomeMsgList other)
```

#### Parameters

`other` [CMsgGCAdditionalWelcomeMsgList](Divine.Protobufs.Dota2.CMsgGCAdditionalWelcomeMsgList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_MergeFrom_Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_"></a> MergeFrom\(CMsgGCAdditionalWelcomeMsgList\)

```csharp
public void MergeFrom(CMsgGCAdditionalWelcomeMsgList other)
```

#### Parameters

`other` [CMsgGCAdditionalWelcomeMsgList](Divine.Protobufs.Dota2.CMsgGCAdditionalWelcomeMsgList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCAdditionalWelcomeMsgList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

