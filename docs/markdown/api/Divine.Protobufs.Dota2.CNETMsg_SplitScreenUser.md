# <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser"></a> Class CNETMsg\_SplitScreenUser

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SplitScreenUser : IMessage<CNETMsg_SplitScreenUser>, IEquatable<CNETMsg_SplitScreenUser>, IDeepCloneable<CNETMsg_SplitScreenUser>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SplitScreenUser](Divine.Protobufs.Dota2.CNETMsg\_SplitScreenUser.md)

#### Implements

IMessage<CNETMsg\_SplitScreenUser\>, 
[IEquatable<CNETMsg\_SplitScreenUser\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SplitScreenUser\>, 
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
[EnumerableExtensions.In<CNETMsg\_SplitScreenUser\>\(CNETMsg\_SplitScreenUser, params CNETMsg\_SplitScreenUser\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser__ctor"></a> CNETMsg\_SplitScreenUser\(\)

```csharp
public CNETMsg_SplitScreenUser()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser__ctor_Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_"></a> CNETMsg\_SplitScreenUser\(CNETMsg\_SplitScreenUser\)

```csharp
public CNETMsg_SplitScreenUser(CNETMsg_SplitScreenUser other)
```

#### Parameters

`other` [CNETMsg\_SplitScreenUser](Divine.Protobufs.Dota2.CNETMsg\_SplitScreenUser.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SplitScreenUser> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SplitScreenUser](Divine.Protobufs.Dota2.CNETMsg\_SplitScreenUser.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_Slot"></a> Slot

```csharp
public int Slot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SplitScreenUser Clone()
```

#### Returns

 [CNETMsg\_SplitScreenUser](Divine.Protobufs.Dota2.CNETMsg\_SplitScreenUser.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_Equals_Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_"></a> Equals\(CNETMsg\_SplitScreenUser\)

```csharp
public bool Equals(CNETMsg_SplitScreenUser other)
```

#### Parameters

`other` [CNETMsg\_SplitScreenUser](Divine.Protobufs.Dota2.CNETMsg\_SplitScreenUser.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_"></a> MergeFrom\(CNETMsg\_SplitScreenUser\)

```csharp
public void MergeFrom(CNETMsg_SplitScreenUser other)
```

#### Parameters

`other` [CNETMsg\_SplitScreenUser](Divine.Protobufs.Dota2.CNETMsg\_SplitScreenUser.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SplitScreenUser_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

